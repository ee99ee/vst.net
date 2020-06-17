# Trouble Shooting

Hopefully some helpful tips when things don't work right away.

## Not all dependencies were found after successful build

As a workaround to another problem with using NuGet packages in a mixed assmebly project, the dependencies for the interop library are hard-coded in the vstnet cli.

Because of that, the final step after a successful build may display warnings that certain dependencies were not found at the NuGet package cache location (`C:\Users\[me]\.nuget\packages\`).

Currently the simplest way around this is to add the missing NuGet dependencies to your project - even if you don't use them. Make sure you match the exact version of the package.

## Plugin won't load in host (DAW)

Depending on the host, a plugin may not load into the DAW. First things you should try:

- Clear plugin caches the host may have.
- Let the host rescan for plugins.

### Match processor architecture

Make sure that the plugin matches the processor architecture of the host. That means if the host is 64-bits, your plugin needs to be build for `x64` and the same goes for 32-bits (`x86`) of course. Most application these days are 64 bits but not all!

### Verify your plugin is correct

In order to eliminate problem areas, you should check if you plugin is correct and has all the required files in its folder.

During development of VST.NET itself the [vsthost](https://www.hermannseib.com/english/vsthost.htm) is used as a test host. If you plugin does not load in this host you know that you are missing files.
You just need to test if the plugin loads (File->New Plugin...).

### Copy `Ijwhost.dll` into host .exe's folder

For some hosts the loading of .NET core does not work at all. It is unclear what the problem is, but copying over the `Ijwhost.dll` file into the same folder the host's .exe is located usually solves the issue.

Clearly this is a workaround and the problem is under investigation.

---

> Back to [Index](index)