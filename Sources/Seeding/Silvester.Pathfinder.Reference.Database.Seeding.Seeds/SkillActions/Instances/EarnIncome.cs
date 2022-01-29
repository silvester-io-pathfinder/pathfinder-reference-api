using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.Tables;
using Silvester.Pathfinder.Reference.Database.Utilities.Tables;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.SkillActions.Instances
{
    public class EarnIncome : Template
    {
        public static readonly Guid ID = Guid.Parse("cb401972-037c-45cc-afe8-f51344f34b5c");

        protected override SkillAction GetSkillAction()
        {
            return new SkillAction
            {
                Id = ID,
                Name = "Earn Income",
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                RequiredProficiencyId = Proficiencies.Instances.Trained.ID
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse("63925fcb-2abd-437c-a8cc-ad1b92973130"), Type = TextBlockType.Text, Text = "When you encounter particularly archaic or esoteric texts, the GM might require you to Decipher the Writing before you can understand it. You must be trained in the relevant skill to Decipher Writing. Arcana is typically used for writing about magic or science, Occultism for esoteric texts about mysteries and philosophy, Religion for scripture, and Society for coded messages or archaic documents." };
            yield return new TextBlock { Id = Guid.Parse("9156e30b-ce80-4224-bdc1-26f136c646c5"), Type = TextBlockType.Text, Text = "You can use a skill - typically Crafting, Lore, or Performance - to earn money during downtime. You must be trained in the skill to do so. This takes time to set up, and your income depends on your proficiency rank and how lucrative a task you can find. Because this process requires a significant amount of time and involves tracking things outside the progress of adventures, it won't come up in every campaign." };
            yield return new TextBlock { Id = Guid.Parse("dd5a67de-afa6-42f6-8070-f1ca2ea71780"), Type = TextBlockType.Text, Text = "In some cases, the GM might let you use a different skill to Earn Income through specialized work. Usually, this is scholarly work, such as using Religion in a monastery to study old texts - but giving sermons at a church would still fall under Performance instead of Religion. You also might be able to use physical skills to make money, such as using Acrobatics to perform feats in a circus or Thievery to pick pockets. If you're using a skill other than Crafting, Lore, or Performance, the DC tends to be significantly higher." };
            yield return new TextBlock { Id = Guid.Parse("476c63d1-1bf8-4226-8cc1-da550ceb958f"), Type = TextBlockType.Text, Text = "You use one of your skills to make money during downtime. The GM assigns a task level representing the most lucrative job available. You can search for lower-level tasks, with the GM determining whether you find any. Sometimes you can attempt to find better work than the initial offerings, though this takes time and requires using the Diplomacy skill to Gather Information, doing some research, or socializing." };
            yield return new TextBlock { Id = Guid.Parse("a60517e8-952f-4ad7-b7b8-991659b75f6f"), Type = TextBlockType.Text, Text = "When you take on a job, the GM secretly sets the DC of your skill check. After your first day of work, you roll to determine your earnings. You gain an amount of income based on your result, the task's level, and your proficiency rank (as listed on Table 4-2: Income Earned)." };
            yield return new TextBlock { Id = Guid.Parse("748d5b46-677e-48c3-8871-1e88034341dd"), Type = TextBlockType.Text, Text = "You can continue working at the task on subsequent days without needing to roll again. For each day you spend after the first, you earn the same amount as the first day, up until the task's completion. The GM determines how long you can work at the task. Most tasks last a week or two, though some can take months or even years." };
        }

        protected override IEnumerable<Guid> GetApplicableSkills()
        {
            yield return Skills.Instances.Acrobatics.ID;
            yield return Skills.Instances.Crafting.ID;
            yield return Skills.Instances.Religion.ID;
            yield return Skills.Instances.Performance.ID;
            yield return Skills.Instances.Thievery.ID;
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield return Traits.Instances.Downtime.ID;
        }

        protected override IEnumerable<Guid> GetRequiredPlayModes()
        {
            yield return PlayModes.Instances.Downtime.ID;
        }

        protected override RollableEffect? GetRollableEffect()
        {
            return new RollableEffect
            {
                Id = Guid.Parse("862d2c3e-32b5-497f-93a9-68b9c1b1fe80"),
                CriticalSuccess = "You do outstanding work. Gain the amount of currency listed for the task level + 1 and your proficiency rank.",
                Success = "You do competent work. Gain the amount of currency listed for the task level and your proficiency rank.",
                Failure = "You do shoddy work and get paid the bare minimum for your time. Gain the amount of currency listed in the failure column for the task level. The GM will likely reduce how long you can continue at the task.",
                CriticalFailure = "You earn nothing for your work and are fired immediately. You can't continue at the task. Your reputation suffers, potentially making it difficult for you to find rewarding jobs in that community in the future."
            };
        }

        protected override IEnumerable<SkillActionExample> GetExamples()
        {
            yield return new SkillActionExample { Id = Guid.Parse("9bd403d4-01c8-4000-8713-0964a6509d8a"), ProficiencyId = Proficiencies.Instances.Trained.ID, Description = "Bartend, do legal research." };
            yield return new SkillActionExample { Id = Guid.Parse("d0c5ced7-76f7-4612-bea9-824c6e0a53ff"), ProficiencyId = Proficiencies.Instances.Expert.ID, Description = "Curate drink selection, present minor court cases." };
            yield return new SkillActionExample { Id = Guid.Parse("f1927f44-1071-4d02-90c3-5fda01d5cff2"), ProficiencyId = Proficiencies.Instances.Master.ID, Description = "Run a large brewery, present important court cases." };
            yield return new SkillActionExample { Id = Guid.Parse("13e3564b-3c2f-4248-b5ee-92ba8a96bc57"), ProficiencyId = Proficiencies.Instances.Legendary.ID, Description = "Run an international brewing franchise, present a case in Hell's courts." };
        }

        protected override Table? GetTable()
        {
            return new TableBuilder("aa8f7d33-3fa3-4e46-9e38-9a3eea339ee7")
                .AddColumn("fff31cb5-7778-41df-94dc-c7474f37e0e8", "Task Level")
                .AddColumn("d5327d4c-fadd-4f02-868a-e6440690bcd8", "Failure")
                .AddColumn("9647569f-51b2-436c-9542-8474eaa2f69e", "Trained")
                .AddColumn("f7c39132-9f82-4167-8efa-eeecb204c1a8", "Expert")
                .AddColumn("c5853a87-9028-4283-96ec-01d51456e065", "Master")
                .AddColumn("917467f6-f43c-4c35-b173-839155f9cc2f", "Legendary")
                .AddRow("2506ae40-8d28-40da-9872-e18692e67473", row =>
                {
                    row
                      .AddCell("fa7ab0dc-dff1-4ec2-9893-d64f0c219ced", "0")
                      .AddCell("f91996b9-8660-46c5-bc0a-93a24336a51f", "1 cp")
                      .AddCell("63d7a1cf-310d-48fc-9c15-52f603d11bcb", "5 cp")
                      .AddCell("2d626c3f-6b47-4180-b432-3d723005dd1e", "5 cp")
                      .AddCell("ac5d4ee0-2dc3-4fd6-9606-18b3ade9416f", "5 cp")
                      .AddCell("c0570be2-5d45-41b5-9721-58810cfe1bb3", "5 cp");
                })
                .AddRow("d054ef56-843d-464a-a26b-fe4ca0af527d", row =>
                {
                    row
                      .AddCell("be2474f6-b063-4881-80d5-891d43eb2984", "1")
                      .AddCell("b8d3a3b2-0beb-401a-955d-49d019966b15", "2 cp")
                      .AddCell("7404b5e5-dd00-4e61-b3cf-95a244ce4963", "2 sp")
                      .AddCell("4509c0cc-c065-4408-bdcf-27171158cb28", "2 sp")
                      .AddCell("3f9503b8-caf3-4f9b-b48a-a70831153b63", "2 sp")
                      .AddCell("5c21b7ba-4554-49b2-9bf7-4d2aca3da54f", "2 sp");
                })
                .AddRow("886136f5-9084-4ee6-a0db-42531fbe2b9a", row =>
                {
                    row
                      .AddCell("846d21de-3008-4900-815b-b1ffe9011498", "2")
                      .AddCell("083f2ebe-400c-4209-88ab-e9e7d2c1dbaf", "4 cp")
                      .AddCell("3ea06ef8-05e0-46f2-b3ea-e97cb1022a04", "3 sp")
                      .AddCell("a9747f59-c3c9-4bdd-83cb-e0f37517c8ad", "3 sp")
                      .AddCell("c73671bd-3784-4427-897a-7193f2ece71b", "3 sp")
                      .AddCell("2c2c3059-e39b-44d0-8a32-02097eca23cf", "3 sp");
                })
                .AddRow("7a945ec0-2473-4078-acef-1ee8225bdfba", row =>
                {
                    row
                      .AddCell("b85bebec-dd7a-4f7c-b300-3b8724596623", "3")
                      .AddCell("facdf695-44ed-493d-9b16-22a8fc0d8784", "8 cp")
                      .AddCell("762e8f0b-0bb8-4964-bb19-21630c3e94a0", "5 sp")
                      .AddCell("17d30391-42a1-4162-a1ca-39471ac1406c", "5 sp")
                      .AddCell("a10f6e11-a4e4-498b-a71b-315aa00c87d5", "5 sp")
                      .AddCell("9e44a2fe-a6c7-43db-8811-33ed0be173a8", "5 sp");
                })
                .AddRow("defb155c-a0fe-4c72-99dc-4f58b344287c", row =>
                {
                    row
                      .AddCell("4c044117-329f-4ea0-a248-94e9ca92fe44", "4")
                      .AddCell("9ccac763-ed2a-4522-80dd-47d36fd9c350", "1 sp")
                      .AddCell("cd84f708-68dc-41c7-8dda-090c6f8c0990", "7 sp")
                      .AddCell("0ec29207-c376-4073-8e9a-6e4451a07fab", "8 sp")
                      .AddCell("b6b55872-7cd7-47f8-963c-67f0e191992c", "8 sp")
                      .AddCell("0ed6e320-75e0-4a7d-b43f-1d2bf3cabc61", "8 sp");
                })
                .AddRow("73062dac-232a-434a-8010-6c6aebc38319", row =>
                {
                    row
                      .AddCell("4fe7ee01-78a9-4fbd-96e1-f6ab2df8fbe8", "5")
                      .AddCell("1e1ed5d3-7e84-403d-8347-8ac8a3b155fb", "2 sp")
                      .AddCell("7f02f4cc-7ef0-482e-9001-1edca620f287", "9 sp")
                      .AddCell("6f3ee319-ca8b-48a2-a49f-a9fb012f1782", "1 gp")
                      .AddCell("c00dc51d-8643-4a1b-9e49-7ea5ba934e7f", "1 gp")
                      .AddCell("c1ff96c3-e11d-4d67-af13-1a1b3c0d1dd6", "1 gp");
                })
                .AddRow("b367bdd5-b9ca-47f1-8786-f398577ba94f", row =>
                {
                    row
                      .AddCell("ba020d20-f7ed-4e8a-b09a-439c50255c48", "6")
                      .AddCell("121c67a9-89dd-46fe-8474-4d453d843cc1", "3 sp")
                      .AddCell("cc7cfe56-251d-47f4-bb1a-9351f792d6fb", "1 gp, 5sp")
                      .AddCell("69b3adc5-0efd-4ef4-8ff8-88b515095899", "2 gp")
                      .AddCell("12d820b7-1082-4091-8404-9858f3f6af8d", "2 gp")
                      .AddCell("5e84d556-6c46-4a59-84db-55925843ea2f", "2 gp");
                })
                .AddRow("1762c55c-8a1b-477a-9a4f-53eab83d219b", row =>
                {
                    row
                      .AddCell("42c4c656-cf25-49d1-8b21-78293a6be1e0", "7")
                      .AddCell("9d1f41fb-ca93-4cfe-bb20-b7efe788664b", "4 sp")
                      .AddCell("9e8404e1-9979-4426-b971-7f30a87640f0", "2 gp")
                      .AddCell("8ccbb6c1-76ac-470c-ae79-bf4fe3e2f549", "2 gp, 5sp")
                      .AddCell("b47215d1-3acf-4ae4-af46-243207b410c5", "2 gp, 5sp")
                      .AddCell("cfd9fc50-6929-4a42-a448-376da5f4d71b", "2 gp, 5sp");
                })
                .AddRow("6549b1ba-00f6-462b-936c-cfd73926b16e", row =>
                {
                    row
                      .AddCell("fef9bdb6-6c55-4587-a335-0edcbf392160", "8")
                      .AddCell("675be7fe-23d3-42b4-b65f-4b485231c3c2", "5 sp")
                      .AddCell("94985a95-42a6-44e8-8340-cd95e5dae355", "2 gp, 5sp")
                      .AddCell("ae4e6119-100d-43f0-88ef-da0061f155ff", "3 gp")
                      .AddCell("ce55b00e-adc9-4d56-81ef-9a7ed4f8492f", "3 gp")
                      .AddCell("c1a260b3-ca67-4623-95d1-c36f5be39764", "3 gp");
                })
                .AddRow("e4233f2b-a37c-4dab-a72d-1cacee163760", row =>
                {
                    row
                      .AddCell("2f82f80b-600e-46a3-941f-1cd9dd6d3a02", "9")
                      .AddCell("747f13bb-9814-4631-9cc8-4767caa7e997", "6 sp")
                      .AddCell("6c89e6fc-b31a-4efd-8610-f3186e5788fa", "3 gp")
                      .AddCell("81f65951-cf5b-482b-972f-917704c3c516", "4 gp")
                      .AddCell("48fbe59c-a52c-41b1-b7dd-8fd5a31fc037", "4 gp")
                      .AddCell("ddf3b6a0-804f-45c1-944f-4a29cdc29c90", "4 gp");
                })
                .AddRow("8d618e8c-40b6-4b94-837b-cc4ffd742ceb", row =>
                {
                    row
                      .AddCell("f6abcc13-f389-46ad-9398-8c430182f6ea", "10")
                      .AddCell("b17da9ee-5ba8-4198-b003-8b3133731056", "7 sp")
                      .AddCell("ec15a404-43c0-4f01-adae-89536d0d09a7", "4 gp")
                      .AddCell("6a650bc0-2027-4bf3-a3ae-1ffe27099e5f", "5 gp")
                      .AddCell("378745ad-178b-492f-b4f7-c61e2dc509eb", "6 gp")
                      .AddCell("e737081a-7af1-409e-8331-cf792a2115df", "6 gp");
                })
                .AddRow("3e5b3947-e816-4070-9a26-1edacd7f1811", row =>
                {
                    row
                      .AddCell("a065baa6-577e-4edb-a43b-08f10f4ddb3e", "11")
                      .AddCell("3a84e5f6-f172-4e4b-b839-76d384b6f37a", "8 sp")
                      .AddCell("5d0d73a1-5fc8-40ba-979d-ed57fc87ed76", "5 gp")
                      .AddCell("a027f7fc-e5a7-4886-8997-473a4704d467", "6 gp")
                      .AddCell("9ac73e3a-b546-4d35-ba6b-4a903630377d", "8 gp")
                      .AddCell("acf31391-3e62-4ffb-9f02-a9f30b0e9c19", "8 gp");
                })
                .AddRow("f1a63097-0276-483e-b1b5-030633a7382f", row =>
                {
                    row
                      .AddCell("81dd328a-e062-46ae-8876-b2aefd75025f", "12")
                      .AddCell("ae00560c-14b4-4a7e-80ad-5f3982638ad7", "9 sp")
                      .AddCell("144e7763-f8d2-4e62-bff9-d10d800cac8c", "6 gp")
                      .AddCell("e30262e8-5b5a-41a1-90a1-99a0d81fa4d0", "8 gp")
                      .AddCell("a8a3140e-6977-4b8e-9145-b0a99af7f172", "10 gp")
                      .AddCell("28b19348-c279-4e9d-a25e-9932a20820dd", "10 gp");
                })
                .AddRow("f6ae033f-ed93-41c3-9261-3a5ed7e102b0", row =>
                {
                    row
                      .AddCell("6835f193-e3e5-4eaf-a23e-6a4c9016b723", "13")
                      .AddCell("660df4d6-5e2f-4b81-bbb8-85fff6adede9", "1 gp")
                      .AddCell("895298fc-65aa-4d14-a40a-342386d616e4", "7 gp")
                      .AddCell("8200ebff-b9fb-40da-af26-c4e9e1b7f570", "10 gp")
                      .AddCell("f20e8bb0-b111-4023-86e2-c2ad388028d5", "15 gp")
                      .AddCell("3fb51d3f-1ae2-429e-a99e-f995bce4d1f2", "15 gp");
                })
                .AddRow("10af4856-4001-4013-a1b0-c8ec505c4314", row =>
                {
                    row
                      .AddCell("4badde46-14bf-4f66-ba6a-79e032068189", "14")
                      .AddCell("17d0c716-a262-45e9-98e0-ea7b5e9241fb", "1 gp, 5sp")
                      .AddCell("7385c966-4674-4a1d-80cb-210db9742902", "8 gp")
                      .AddCell("5d67772e-9ebe-45a9-9f2f-4a33071d7da2", "15 gp")
                      .AddCell("344ef106-22b6-4b14-9e4a-8f2386911852", "20 gp")
                      .AddCell("41f7a7c1-2011-4cf0-b258-8acdd221333f", "20 gp");
                })
                .AddRow("3d30f7a7-2e8f-4613-9ab3-b92655d53213", row =>
                {
                    row
                      .AddCell("327d5551-02b5-4723-8ba2-3110780852c7", "15")
                      .AddCell("b9c2112b-cc36-4a0d-b46e-ad97dc6f3221", "2 gp")
                      .AddCell("b1275928-c70e-4480-be68-4cd9a7b2ecd8", "10 gp")
                      .AddCell("8f308934-c241-4ebe-8126-7383bbb9d254", "20 gp")
                      .AddCell("99035245-8b04-4056-a545-3d02eaac8289", "28 gp")
                      .AddCell("f0e3bd91-9bfe-4fe6-989b-6de4297cbfb7", "28 gp");
                })
                .AddRow("26429c24-7998-4893-811f-4e2d71d598ac", row =>
                {
                    row
                      .AddCell("16bdaa3e-8ea6-437f-a41d-064fdc9a39c6", "16")
                      .AddCell("c654e4af-bedc-4ac3-a179-5f682c855bed", "2 gp, 5sp")
                      .AddCell("cd0e8603-8ae6-4a50-965d-60ad4e5d737d", "13 gp")
                      .AddCell("d41eb5df-c3f7-42ac-a5aa-eae002aa6409", "25 gp")
                      .AddCell("2590aa85-0239-45da-9a3a-ef51ee61d09a", "36 gp")
                      .AddCell("7d802e98-11b9-4008-803f-0e3ae42b45e5", "40 gp");
                })
                .AddRow("db51adac-fb79-4183-a188-a8fa710c2758", row =>
                {
                    row
                      .AddCell("92d74e3f-96a7-40f4-85c7-98c9934860d3", "17")
                      .AddCell("51238e77-f8b3-46a0-a8d6-6891fa769098", "3 gp")
                      .AddCell("b8b9a51c-c2a4-4881-94d4-7a9363f91329", "15 gp")
                      .AddCell("1bd8ddf5-e199-446c-a547-dad20ce2ebff", "30 gp")
                      .AddCell("29bf635b-f1eb-43b6-ba7b-4235d0e4dbf8", "45 gp")
                      .AddCell("ffd521e9-f150-4f3e-9560-d99ac4f8fd04", "55 gp");
                })
                .AddRow("6e525349-c831-4a53-b9e1-29371b7242ee", row =>
                {
                    row
                      .AddCell("c5c3b035-ce9b-472f-8d23-f9fcc6e6a3d7", "18")
                      .AddCell("2bc5feaf-0e5e-4510-bf8a-6b8b89df0a1e", "4 gp")
                      .AddCell("e6eeb376-9ae9-4167-82d9-608484841c2e", "20 gp")
                      .AddCell("3cf2d064-edd4-4ad6-aafd-ee5fd82d790f", "45 gp")
                      .AddCell("fd478027-28e2-4f13-97ff-7e8ff4683ce0", "70 gp")
                      .AddCell("c693d814-876a-42e2-b52c-d3ac94c5f5ce", "90 gp");
                })
                .AddRow("30f405f9-b3bf-424b-9829-cc1681aa766b", row =>
                {
                    row
                      .AddCell("6e8453a6-660e-4238-bc9d-3932fc83666e", "19")
                      .AddCell("976f10f4-49ef-49c7-8bb1-5f522ef6a925", "6 gp")
                      .AddCell("3ae90ae6-328f-4677-9c26-d570c45d5490", "30 gp")
                      .AddCell("66e8dab2-84ab-4e06-8657-c51d45a0a463", "60 gp")
                      .AddCell("11c7fe26-2eb6-4e78-bb8d-06cc161b919d", "100 gp")
                      .AddCell("abc50015-477f-492b-abac-42999adafb0b", "130 gp");
                })
                .AddRow("b56960e5-42c1-4b15-a60a-ff1f94446d94", row =>
                {
                    row
                      .AddCell("f80e3130-0669-42ee-a45c-6ad6bca0e36b", "20")
                      .AddCell("af9e395a-1554-47d5-b7ca-7b2280177db6", "8 gp")
                      .AddCell("8a10762f-6379-421d-b6ce-803b76679ac9", "40 gp")
                      .AddCell("3cbf7f00-1050-4e97-9304-9d48c4a3aa9e", "75 gp")
                      .AddCell("2bb6ee2a-d3e8-47f5-a300-f797a6125f23", "150 gp")
                      .AddCell("6f8bb929-eb04-4aa0-9141-b42085499c92", "200 gp");
                })
                .AddRow("9c023795-430a-4b26-8e30-bcb3efcae01b", row =>
                {
                    row
                      .AddCell("a8f24cd2-5c62-43aa-b2c3-4f4fd9c3b1b5", "20 (critical success)")
                      .AddCell("9c9cf2c4-828f-4a47-aad5-776a013e67ce", "-")
                      .AddCell("bdbdbe23-a986-4d05-9b2c-636e80ba137a", "50 gp")
                      .AddCell("ce3e8b88-efcc-4063-b2d5-83404fc4336e", "90 gp")
                      .AddCell("9abefb87-7175-49b7-bc67-917038927e41", "175 gp")
                      .AddCell("0b459329-5526-488c-af78-90740b07cec1", "300 gp");
                })
                .Build();
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("333d206f-59de-4682-83ed-3677dd0a2f12"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 236
            };
        }
    }
}
