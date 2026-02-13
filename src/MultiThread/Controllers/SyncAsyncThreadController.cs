using Microsoft.AspNetCore.Mvc;

namespace MultiThread.Controllers;

[ApiController]
[Route("thread")]
public class SyncAsyncThreadController(ILoggerAdapter<SyncAsyncThreadController> logger) : ControllerBase
{
    [HttpGet("sync")]
    public IActionResult Sync()
    {
        logger.LogInformation("Block thread sync called");

        Thread.Sleep(5000);

        logger.LogInformation("Block thread sync thread released");

        return Ok("Done");
    }

    [HttpGet("async")]
    public async Task<IActionResult> Async(CancellationToken cancellationToken)
    {
        logger.LogInformation("Block thread async called");

        await Task.Delay(5000, cancellationToken);

        logger.LogInformation("Block thread async thread released");

        return Ok("Done");
    }
}