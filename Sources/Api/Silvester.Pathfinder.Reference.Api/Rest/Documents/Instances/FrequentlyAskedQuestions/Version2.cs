using Silvester.Pathfinder.Reference.Api.Rest.Documents.Models;
using Silvester.Pathfinder.Reference.Documents.Models;
using System;

namespace Silvester.Pathfinder.Reference.Api.Rest.Documents.Instances.FrequentlyAskedQuestions
{
    public class Version2 : IDocumentProvider
    {
        public DocumentType Type => DocumentType.FrequentlyAskedQuestions;
        public int Version => 2;
        public Document Document => new Document.Builder(DateTime.Parse("2021-09-18"), DateTime.Parse("2021-10-04"), 1)
            .AddSection("Why build yet another rules explorer?", section =>
            {
                section.AddSubSection(null, sub =>
                {
                    sub.AddParagraph("While it is definitely true that there are many more (excellent) rule-explorer type web and mobile applications out there, I was not able to find one with a generic and re-usable API, or one that was open-source (or even source-available).");
                    sub.AddParagraph("Other than that, it was a great opportunity to get some initial experience with the rules, as I had never played a tabletop RPG before, and the plethora of systems initially seemed very daunting.");
                    sub.AddParagraph("Finally, it's just a very fun little side-project that has given me a lot of satisfaction!");
                });
            })
            .AddSection("Why are so many entities still missing?", section =>
            {
                section.AddSubSection(null, sub =>
                {
                    sub.AddParagraph("The seeding process is arduous, and I only have limited time besides work and family to put into this project.");
                    sub.AddParagraph("For all of the existing entity types, however, all of the seeding has been completely templated, so pretty much anyone (whether you have software development experience or not) can contribute here, and setting up new templates for non-existent entity types should be reasonably straightforward as well.");
                });
            })
            .AddSection("Are you completely true to the documentation?", section =>
            { 
                section.AddSubSection(null, sub =>
                {
                    sub.AddParagraph("Sadly, I am not. I found that the rulebooks are too inconsistent and ambiguous for anyone to create a consistent and unambiguous standard for it. This has lead me to ad-lib some details, effects, or even whole conditions (I'm looking at you, Choked).");
                    sub.AddParagraph("In cases where it's more than some spelling errors or a slight restructuring, a disclaimer will be shown, letting you know that these might not be the official rules.");
                });
            })
            .AddSection("Why is pf2e.io offline (at least) once a day?", section =>
            {
                section
                    .AddSubSection(null, sub =>
                    {
                        sub.AddParagraph("All resources and services are hosted on a private, managed Kubernetes cluster on the Google Cloud Platform (GCP). This is not cheap, but opting for so called 'preemptible' nodes cuts these costs down by about a two-thirds (from about €140 to about €50.00 per month, just for the nodes).");
                        sub.AddParagraph("While saving significantly on operational costs, 'preemtible nodes' have no availability guarantees whatsoever. They have a maximum lifespan of 24 hours, and can theoretically be moved to different data-centers by Google at any point in time in an ad-hoc fashion, leading to unavailable pf2e.io services.");
                    });
            })
            .AddSection("Isn't a Kubernetes cluster on GCP a little over-engineered?", section =>
            {
                section.AddSubSection(null, sub =>
                {
                    sub.AddParagraph("Some might argue that it is, and they would probably have a decent point. While hosting on Google Cloud Platform is expensive, and brings along additional costs in complexity, it also brings a lot of benefits to the table.");
                    sub.AddParagraph("A small excerpt of just some of the reasons I opted for Kubernetes are self-healing applications and clusters, managed persisted storage, configuration-as-code, out-of-the-box canary and blue-green deployment strategies, and superb integration with other open-source and proprietary packages (such as Prometheus, Grafana, ArgoCD, et cetera).");
                    sub.AddParagraph("Other than that, this side project was also an opportunity for me to get more experience with GCP and Kubernetes, and all of the other used technologies.");
                });
            })
            .AddSection("Why can I not find you on Google?", section =>
            {
                section.AddSubSection(null, sub =>
                {
                    sub.AddParagraph("That's a good question, to which the slightly sad and unfortunate answer is that I have no experience (yet) with Search Engine Optimization (SEO), and have not taken the time (yet) to look in to it.");
                    sub.AddParagraph("If you or someone you know has experience with SEO (or simply wants to obtain some experience in it) feel free to contribute or get in touch!");
                });
            })
            .AddSection("Can I use the generic GraphQL API for my own projects?", section =>
            {
                section
                    .AddSubSection(null, sub =>
                     {
                         sub.AddParagraph("See the latest version of the License Agreement document. In summation, you are free to use the API for non-commercial projects such as a passion project or side-project, but as soon as it becomes commercial, we'll have to work out a licensing agreement for that specific use-case to ensure that there's fair-use and fair compensation for everyone involved.");
                     });
            })
            .AddSection("Why are you source-available instead of open-source?", section => 
            {
                    section.AddSubSection(null, sub =>
                    {
                        sub.AddParagraph("This was a personal decision for me, for which much of the deliberation was rooted in my conviction that everyone, no matter how small a party, should be fairly compensated for any work that has contributed to any potential gains.");
                        sub.AddParagraph("The source-available model allows me to enable anyone to create passion projects (or contribute in some other transient way to the Pathfinder community), without running any significant risk of being left stranded in the side-lines.");
                    });
            })
            .AddSection("How can I contribute?", section => 
            {
                section.AddSubSection(null, sub =>
                {
                    sub.AddParagraph("There's loads of things I could use help with, and any contribution is much appreciated, whether that's with work you want to put in, or by simply buying me a beer. Feel free to reach out to me, or open issues, feature-requests, or pull-requests on any of the GitHub projects!");
                });
            })
            .AddSection("What's next?", section =>
            {
                section.AddSubSection(null, sub =>
                {
                    sub.AddParagraph("There's still a lot of seeding and polishing left to do, but after that: you name it. The GraphQL API should be generic enough to support a broad range of services. Perhaps a character builder, or an encounter builder, or a physical card adapter, or ...");
                });
            })
            .AddSection("How can I contact you?", section =>
            {
                section.AddSubSection(null, sub =>
                {
                    sub.AddParagraph("For now your most likely bets are Twitter, GitHub and Reddit, but there's also a brand-new Discord server for Patreons where you can talk to me directly.");
                });
            })
            .Build();
    }
}
