using Silvester.Pathfinder.Reference.Api.Rest.Documents.Models;
using Silvester.Pathfinder.Reference.Documents.Models;
using System;

namespace Silvester.Pathfinder.Reference.Api.Rest.Documents.Instances.LicenseAgreements
{
    public class Version1 : IDocumentProvider
    {
        public DocumentType Type => DocumentType.LicenseAgreements;
        public int Version => 1;
        public Document Document => new Document.Builder(DateTime.Parse("2021-07-01"), DateTime.Parse("2021-07-01"), 1)
            .AddSection("Dual Licensing", section =>
            {
                section.AddSubSection(null, sub =>
                {
                    sub.AddParagraph("The pf2e.io sources are released under a dual-licensing approach. Any use of, changes to, or distribution of the original or modified code agrees to one of the following licenses.");
                    sub.AddParagraph("1.    If you wish to use the software in a non-commercial manner for one year, you may download and access the source and/or binaries at no charge under the PolyForm NonCommercial license (https://polyformproject.org/wp-content/uploads/2020/05/PolyForm-Noncommercial-1.0.0.txt).");
                    sub.AddParagraph("2.    If you wish to use the software commercially for one year, you may download and use them (with the appropriate levied fees) under the Software License Agreement below.");
                });
            })
            .AddSection("tl;dr", section =>
            {
                section.AddSubSection(null, sub =>
                {
                    sub.AddParagraph("If you want to use the pf2e.io software or resources in a non-commercial setting (e.g. for a passion project), you are free to do so under the PolyForm NC license. This is a so called source-available license, and allows you to see, browse and contribute to the source code of the pf2e.io software.");
                    sub.AddParagraph("As soon as you start making any sort of money from the goods or services you produce using the pf2e.io software or resources, you are forced to enter into negotiations with us to come to a custom Software License Agreement such as the one listed below, in which we’ll find an appropriate model for your specific use-case. This is in part to ensure fair competition, as well as the make sure that any derivative work is in accordance with Paizo's agreements.");
                });
            })
            .AddSection("Software License Agreement", section =>
            {
                section.AddSubSection(null, sub =>
                {
                    sub.AddParagraph("This Software License Agreement (“Agreement”) is a legal agreement between you (either as an individual or a single entity (“You”)) and Silvester Consultancy B.V. (“Licensor”) for the source code, libraries, online or electronic documentation, and other materials provided to You in the applicable download, and any upgrades, modified versions, bug fixes, additions and improvements thereof that Licensor may make available during the term of the Agreement (the “Software”).");
                    sub.AddParagraph("References to “You” herein shall refer to you, and/or the entity on whose behalf you are using the Software, and all individual developer-users of the Software on behalf of such entity. ");
                    sub.AddParagraph("By downloading, installing, or otherwise accessing or using the Software, you explicitly agree that you have read, understood and agree to be bound by this agreement. If you do not agree, you may not use the Software.");
                    sub.AddParagraph("Accordingly, You and Licensor acknowledge and agree as follows:");
                });

                section.AddSubSection("1. LIMITED LICENSE", sub =>
                {
                    sub.AddParagraph("Subject to your complete and ongoing compliance with all the terms and conditions set forth in this Agreement, including without limitation all license limitations and restrictions set forth herein, Licensor grants You the following limited, non-exclusive, non-transferable, non-sublicensable, revocable license to use, and (where applicable) authorize your employees and other personnel to use, the unmodified Software internally solely in connection with developing your own client software applications, or other goods, products or services, granted that you have submitted to the custom percentage-based kickback fee on revenue resulting from goods, products, services or other forms of revenue-generating concepts that use or in some other way rely on the Software to generate value (the “Benefactors”). This percentage differs per commercial licensing agreement and is subject to change only after the license has been in effect for one year, but may be silently extended thirty days at a time.");
                });

                section.AddSubSection("2. RESTRICTIONS", sub =>
                {
                    sub.AddParagraph("A. You acknowledge that the license granted in paragraph 1 does not include any right to (i) redistribute, sell, lease, license, or modify any portion of the Software, (ii) reproduce, distribute, publicly display, or publicly perform any part of the Software, (iii) modify the source code of any portion of the Software (unless they are modifications made through contributions to the Software under its non-commercial use license), or (iv) remove, obscure, interfere with or circumvent any feature of the Software, including without limitation any copyright or other intellectual property notices, security, or access control mechanism. ");
                    sub.AddParagraph("B. You may only use the Software in connection with the related Benefactors for which you have subjected to the custom percentage-based kickback fee on revenue.");
                    sub.AddParagraph("C. You may not sell, license, distribute, copy, modify, publicly perform or display, transmit, publish, edit, adapt, create derivative works from, or make any use of the Software except as expressly authorized in this Agreement or any potential, signed addenda used to adapt the Agreement to You.");
                    sub.AddParagraph("D. If You are prohibited under applicable law from using the Software, You not use the Software, and You will comply with all applicable laws and regulations (including without limitation laws and regulations related to export controls) in connection with your use of the Software.");
                });

                section.AddSubSection("3. PRESERVATION OF RIGHTS", sub =>
                {
                    sub.AddParagraph("The Software is owned by Licensor and licensed, not sold, to You. The Software is protected by copyright laws and international copyright treaties, as well as intellectual property laws and treaties as active in The Netherlands. Except for the limited rights of use granted herein, all right, title and interest to the Software, including patent, copyright, and trademark rights in and to the Software, the accompanying printed materials, and any copies of the Software are owned by Licensor.");
                });

                section.AddSubSection("4. CONFIDENTIALITY", sub =>
                {
                    sub.AddParagraph("The Software is the confidential and proprietary information of Licensor, and You may not, during the term of thereafter, disclose it to any third party, or to use it for any purpose other than as expressly provided herein, without a separate written agreement with Licensor authorizing You to do so. The foregoing does not prevent You from making commercially available any goods, products or services that in any way relies on the Software to add its value.");
                });

                section.AddSubSection("5. FEEDBACK", sub =>
                {
                    sub.AddParagraph("If You provide Licensor with any comments, bug reports, feedback, enhancements, or modifications proposed or suggested by You for the Software (“Feedback”), such Feedback is provided on a non-confidential basis (notwithstanding any notice to the contrary You may include in any accompanying communication), and Licensor shall have the right to use such Feedback at its discretion, including, but not limited to the incorporation of such suggested changes into future releases of the Software. You hereby grant Licensor a perpetual, irrevocable, transferable, sublicensable, nonexclusive license under all rights necessary to incorporate and use your Feedback for any purpose, including to make and sell any products and services.");
                });

                section.AddSubSection("6. TERMS AND TERMINATION", sub =>
                {
                    sub.AddParagraph("The Agreement will remain in effect for one year, unless otherwise agreed upon in any signed addenda aimed at tailoring the Agreement to You from the date both You and Licensor officially submitted to the terms in the Agreement in a written agreement. However, Licensor may terminate this Agreement upon 30 days’ prior written notice allowing You the opportunity to cure, for any actual or suspected misuse or abuse by You of the Software or any material violation of the Agreement. You may also choose to terminate this Agreement for any reason by ceasing all use of the Software. Following any termination of this Agreement, You will not be provided any refund, in whole or in part, and You must immediately cease all use of the Software, and cease all exploitation, for-profit or otherwise, of goods and services that were created with the use of the Software, and be able to show evidence of such cessation to Licensor upon request. The terms of the Agreement that expressly are to, or by implication ought to, survive, will survive the Agreement. Notwithstanding the foregoing, should Licensor completely cease to do business (excluding transactions in connection with a sale of all or substantially all of Licensor’s assets or stock, or in connection with a merger or other corporate reorganization), the term of the Agreement shall be perpetual as to any goods or services already created with the help of the Software at the time of such cessation.");
                });

                section.AddSubSection("7. WARRANTY DISCLAIMER AND LIMITATION OF LIABILITY", sub =>
                {
                    sub.AddParagraph("The Software is provided on an “as is” basis, without warranty of any kind. To the maximum extent permitted by applicable law, Licensor disclaims all warranties and conditions, express, implied, statutory or otherwise, including but not limited to implied warranties or conditions of fitness for a particular purpose, merchantability, title, quality, results, and non-infringement. Under no circumstances will Licensor be liable for any consequential, special, indirect, incidental or punitive damages whatsoever arising out of the use or inability to use the Software, even if Licensor has been advised of the possibility of such damages, and notwithstanding any failure of essential purpose of any limited remedy. In no event will Licensor’s aggregate liability for damages arising out of the Agreement or the terms exceed the amount paid by You for the Software. Some jurisdictions do not allow limitations on implied warranties or the exclusion or limitation of liability for consequential or incidental damages, so the above limitations may not apply to You. In such an event, the above limitations and exclusions will be enforced to the maximum extend permitted under applicable law.");
                });

                section.AddSubSection("8. INDEMNITY", sub =>
                {
                    sub.AddParagraph("You agree to indemnify Licensor and its affiliates, officers, directors, suppliers, licensors, and other customers from and against any and all liability and costs (including reasonable attorneys’ fees) incurred by such parties in connection with or arising out of your Benefactors or your use of, misuse of or failure to use the Software.");
                });

                section.AddSubSection("9. GOVERNING LAW", sub =>
                {
                    sub.AddParagraph("This Agreement shall be governed by and interpreted in accordance with the laws and jurisdiction of the country in which Licensor is vested. You hereby consent to submit to personal jurisdiction and venue exclusively in the courts of The Netherlands, or higher European Union courts of law.");
                });

                section.AddSubSection("10. GENERAL PROVISIONS", sub =>
                {
                    sub.AddParagraph("A. You will be responsible for the payment of all taxes, duties, levies, and other charges including, but not limited to sales, use, gross receipts, excise, VAT, ad valorem and any other taxes, any withholdings or deductions, import and custom taxes, any duties or other charges imposed by any taxing authority (excluding any taxes based on the Licensor’s income) with respect to the fees payable to Licensor in connection with the Agreement.");
                    sub.AddParagraph("B. The Agreement contains the entire agreement between You and Licensor, supersedes any other agreements or discussions, oral and written, concerning the subject matter hereof, and may not be modified or amended except by a written amendment signed by both parties.");
                    sub.AddParagraph("C. If any provision of the Agreement is declared invalid, illegal or unenforceable by a court of competent jurisdiction, such provision shall, as to that jurisdiction, be ineffective only to the extent of such invalidity, illegality, or unenforceability, and shall not in any manner affect the remaining provisions hereof in such jurisdiction or render any other provision of the Agreement invalid, illegal, or unenforceable in any other jurisdiction.");
                    sub.AddParagraph("D. You agree that in the event of a breach or threatened breach of the Agreement, Licensor may suffer irreparable harm and will be entitled to specific performance, and preliminary and/or permanent injunctive relief to enforce the Agreement without the need to post bond and that such relief shall be in addition to, and not in lieu of, any monetary damages or other relief a court of competent jurisdiction, whether at law or equity, may award.");
                });
            })
            .Build();
    }
}
