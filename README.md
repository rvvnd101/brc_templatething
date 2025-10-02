# setups :3
* Install dotnet and whatnot, maybe get a good editor like vscode or visual studio aswell (i'm not explaining that stuff in detail rn)
* Set the `BRCPath` environment variable to the installation directory (t.ex `C:\Steam\steamapps\common\BombRushCyberfunk`)
* Set the `BepInExDirectory` environment variable to your bepixex directory (t.ex if you are using r2modman it should be around `%AppData%\r2modmanPlus-local\BombRushCyberfunk\profiles\(profile)\BepInEx`)

# have you done this b4 release?
* changed details in
    * everything in `manifest.json`?
    * name, assemblyname, and author in `Plugin/Plugin.csproj`?
    * `icon.png`?
    * this file? (yes, it gets included in the thunderstore output)
* built for thunderstore via `./scripts/build.ps1`?
    * run while in the root directory of the project, remember to review the script *before* you run it even if you trust me.
    * the output should be in `out/plugin.zip`, ready for thunderstore

# todos on my part
- [ ] add ui example
- [ ] just make a better example, this one lowk sucks ass and i gotta shove a ui element in for boilerplate reasons or something
- [ ] maybe a branch with commonapi and whatnot
- [ ] maybe something else i guess idk tbh
