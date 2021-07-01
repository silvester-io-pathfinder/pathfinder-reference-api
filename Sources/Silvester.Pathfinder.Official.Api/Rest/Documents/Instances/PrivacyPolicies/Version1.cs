using Silvester.Pathfinder.Official.Api.Rest.Documents.Models;
using Silvester.Pathfinder.Official.Documents.Models;
using System;

namespace Silvester.Pathfinder.Official.Api.Rest.Documents.Instances.PrivacyPolicies
{
    public class Version1 : IDocumentProvider
    {
        public DocumentType Type => DocumentType.PrivacyPolicies;
        public int Version => 1;
        public Document Document => new Document.Builder(DateTime.Parse("2021-07-01"), DateTime.Parse("2021-07-01"), 1)
               .AddSection("Ownership", section =>
               {
                   section
                   .AddSubSection(null, sub =>
                   {
                       sub.AddParagraph("The website and applications hosted at https://www.pf2e.io (and all of its subdomains) are operated by and property of Silvester Consultancy B.V., whose office is situated at Middenburcht 30, Vleuten - The Netherlands. Proper operation of these platforms is supported by the collection and use of the personal information of its users. In this document, we will attempt to inform you of our policies regarding this information. By using this website and its services, you implicitly agree to the collection and use of your personal information in accordance to the policies described in this document.");
                   });
               })
               .AddSection("Data Collection", section =>
               {
                   section.AddSubSection("Cookies", sub =>
                   {
                       sub.AddParagraph("Cookies are small data files that are stored on the computer of a website’s visitor. They are often used to identify individuals who are logged in, or to identify individuals as they navigate through the website.");
                       sub.AddParagraph("In the case of our products and services, we use cookies keep track of you as you navigate through our websites. The duration of these cookies last anywhere from a single session to one year. These cookies are a result of website traffic analyses using Google Analytics. This may help us to improve our designs and tailor it to individual needs. We will only use this information for statistical and design analysis in order to improve our services towards our users.");
                       sub.AddParagraph("You can instruct your browser to refuse all cookies or to indicate when a cookie is being sent. However, if you do not accept cookies, you may not be able to properly use our website and might experience strange and undesirable behaviour.");
                   });
               })
               .AddSection("Security", section =>
               {
                   section.AddSubSection("Communications", sub =>
                   {
                       sub.AddParagraph("For secure communication between two end-systems, this website employs Secured Socket Layer (SSL), which is an encrypted communications protocol. This means that all communication will be encrypted before being sent over the internet to its destination. This prevents intruders who intercept the data to make any sense of what it actually means, keeping your private data safe.");
                   });
               })
               .AddSection("Other Websites", section =>
               {
                   section.AddSubSection(null, sub =>
                   {
                       sub.AddParagraph("As a part of the services provided by our products, we can present you with a number of links to other local and international organisations and agencies. Once referred, you will no longer be subject to the privacy policy of pf2e.io, but rather the policies of the data controller of the new site.");
                   });
               })
               .AddSection("Policy Changes", section =>
               {
                   section.AddSubSection(null, sub =>
                   {
                       sub.AddParagraph("This privacy policy came in to effect at 2020/06/30 and will remain in effect until the liquidation of the company. Any potential changes to this policy will come in to effect immediately after being updated on this webpage. ");
                       sub.AddParagraph("We reserve the right to update or change this privacy policy at any time and you are advised to check this policy at regular intervals. Your continued use of our websites, products and services after these updates constitute your acknowledgment of these changes and your consent to abide and be bound by the modified privacy policy.");
                   });
               })
               .AddSection("Contact Information", section =>
               {
                   section.AddSubSection(null, sub =>
                   {
                       sub.AddParagraph("Any questions, comments or suggestions that you have regarding this privacy policy, which may contribute to a better quality of service are welcome and greatly appreciated. You can address these questions, comments or suggestions to us via GitHub or Reddit.");
                   });
               })
               .Build();
    }
}
