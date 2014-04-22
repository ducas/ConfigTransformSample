ConfigTransformSample
=====================

Sample project for transforming config files for Azure Web Sites.

### Why...? ###

Because you often deploy to lots of environments - **not** build configurations. Visual Studio now supports a convention for transforming **web.config** files based on Publish Profiles (see [ScottHa's post](http://www.hanselman.com/blog/TinyHappyFeatures3PublishingImprovementsChainedConfigTransformsAndDeployingASPNETAppsFromTheCommandLine.aspx)). It only seems logical that this should be supported in Azure Web Sites.

Also, now that we have Web Jobs, we should be able to use the same convention for transforming **app.config** files for jobs that are being deployed.

### Supporting Packages ###

* [WebJobsVs](https://github.com/ligershark/webjobsvs) - deploys a Web Job into a Web Site when publishing.
* [SlowCheetah](http://visualstudiogallery.msdn.microsoft.com/69023d00-a4f9-4a34-a6cd-7e854ba318b5) - allows you to transform and config file.

## Web.Config Transforms ##

Check out [this post](http://brian.vallelunga.com/blog/chaining-azure-web-config-transforms-when-deploying-from-source-control) for information on how web.config files can be transformed.

## App.Config Transforms ##

*If you haven't seen [Brian's post mentioned in **Web.Config Transforms**](http://brian.vallelunga.com/blog/chaining-azure-web-config-transforms-when-deploying-from-source-control), then go read it.*

Basically, to transform App.Config files I've used the same principal as with Web.Config files, but invoked SlowCheetah using a **BeforeBuild** MSBuild task. This modifies the local App.Config before the job is compiled to an output director.