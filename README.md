# SocialAlloyThis repository contains a clone of the Episerver Alloy sample application, which has been extended to demonstrate the features of Episerver Social. The goals for this project are twofold:* To provide a simple application demonstrating Episerver Social features and capabilities* To provide developers looking to get started with Episerver Social with a helpful point of reference## Release Notes* Version 1.0.0 * This release introduces several block types, which demonstrate simple implementations of various Episerver Social features.## Getting StartedAn Episerver Social account is required to run this application. If you do not have an Episerver Social account, please contact your Episerver account manager.### Setup* Run the setup script with Powershell: `.\src\Scripts\Setup.ps1`* Open the SocialAlloy.sln in Visual Studio* Open the web.config and update the `episerver.social` configuration section with your account information. * For more information on how to configure Episerver Social, [please visit our Getting Connected guide](http://world.episerver.com/documentation/developer-guides/social/social_platform-overview/Installing-Episerver-Social/#GettingConnected).### Running the Application* Build the application in Visual Studio 2015 * This operation will restore the necessary NuGet packages dependencies.* Launch the application from Visual Studio 2015 * With debugging (F5) * Without debugging (CTRL+F5)## Feature ConfigurationSocial features are implemented using Episerver blocks.  Episerver blocks are available for the following Episerver Social features:* Comments* Ratings* Groups* Moderation* Activity StreamsTo configure an Episerver Social feature block in a page do the following:* Login to the SocialAlloy CMS edit panel* Create a new block and select the "**&lt;feature&gt;** Block"* Tweak any configuration in the block properties* Publish the block* Go to the page where the block functionality is desired* Add/drag the block anywhere in the page* Publish the modified page* Viewing the page in the frontend should allow the use of that block's social featureFor implementation details of each of the Episerver social blocks see the [source code](https://github.com/episerver/SocialAlloy/tree/release/1.0.0/src/EPiServer.SocialAlloy.Web/Social)## Developer ReferenceDevelopers looking to get started with Episerver Social will find the repository implementations as the primary point of interaction between the application and the Episerver Social framework.* /src/EPiServer.SocialAlloy.Web/Social/Repositories/*## More InformationFor detailed information on how to implement social content solutions with Episerver Social, [please visit Episerver World](http://world.episerver.com/documentation/developer-guides/social/).## IssuesIf you encounter a problem, please [open a new issue](https://github.com/episerver/SocialAlloy/issues/new).## ContributionsIf you'd like to contribute a change:* Create a branch from the latest release/* branch* Add commits* [Open a pull request](https://github.com/episerver/SocialAlloy/compare)