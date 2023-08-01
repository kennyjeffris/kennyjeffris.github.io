return await Bootstrapper
  .Factory
  .CreateWeb(args)
  .DeployToGitHubPages(
    "kennyjeffris",
    "kennyjeffris.github.io",
    Config.FromSetting<string>("GITHUB_TOKEN"))
  .RunAsync();