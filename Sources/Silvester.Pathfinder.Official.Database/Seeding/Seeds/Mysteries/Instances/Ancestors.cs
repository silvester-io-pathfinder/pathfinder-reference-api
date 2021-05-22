using Silvester.Pathfinder.Official.Database.Models;
using Silvester.Pathfinder.Official.Database.Utilities.Tables;
using Silvester.Pathfinder.Official.Database.Utilities.Text;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Mysteries.Instances
{
    public class Ancestors : Template
    {
        public static readonly Guid ID = Guid.Parse("27eab9f4-e610-4eaa-8288-2b531cb6bcee");

        protected override Mystery GetMystery()
        {
            return new Mystery
            {
                Id = ID,
                Name = "Ancestors",
                InitialRevelationId = Spells.Instances.AncestralTouch.ID,
                AdvancedRevelationId = Spells.Instances.AncestralDefense.ID,
                GreaterRevelationId = Spells.Instances.AncestralForm.ID,
                GrantedCantripId = Spells.Instances.Guidance.ID,
                TrainedSkillId = Skills.Instances.Society.ID 
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("fcc67e88-9d62-4e8f-ac74-d82d715db235"), Type = TextBlockType.Text, Text = "The voices of generations past speak to you, and you hear their words. You might resent the constant interruption, or you might revere the spirits of those who came before. Perhaps you hail from a culture with strong ancestral traditions, such as the Shoanti Skoan-Quah (Skull Clan), a traditional dwarven community that worships Torag's family pantheon, or a group that reveres Erastil or Pharasma. You might commune with powerful psychopomps who shepherd souls to the afterlife, with the River of Souls itself, or with those spirits who have become trapped outside of the great cycle of spiritual rebirth. You learn from their whispers and the fragments of their memories, but opening your mind to their knowledge and experience also allows them to meddle in your worldly affairs." };
        }

        protected override IEnumerable<TextBlock> GetBenefitBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("7caedfb9-0fc3-4947-a71c-f48432ae3e8f"), Type = TextBlockType.Text, Text = "The whispers of your ancestors have bestowed additional knowledge upon you. You gain an additional ancestry feat at 1st level and another additional ancestry feat at 11th level. These feats can't be ones that grant physiological effects, such as additional senses or unarmed attacks." };
        }

        protected override IEnumerable<Guid> GetDomains()
        {
            yield return Domains.Instances.Death.ID;
            yield return Domains.Instances.Family.ID;
        }

        protected override MysteryCurse GetCurse()
        {
            return new MysteryCurse
            {
                Id = Guid.Parse("ad233848-92de-4bf0-a8d7-237297aa5001"),
                Name = "Curse of Ancestral Meddling",
                SourcePage = new SourcePage
                {
                    Id = Guid.Parse("90a18531-4bb0-412b-a069-a459060552a4"),
                    SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                    Page = 73
                },
                Details = new TextBlock[]
                {
                    new TextBlock { Id = Guid.Parse("a1df679f-6eb9-48e2-91d2-ffa2fe340048"), Type = TextBlockType.Text, Text = "The ancestral spirits you commune with haunt you and meddle with your belongings and actions, either out of a well-intentioned (but ultimately detrimental) attempt to assist you, as punishment for your audacity in circumventing the traditional means of achieving divine power, for their own amusement, or a mixture of the above. Your hair, clothing, and belongings constantly shift and stir, seemingly of their own volition. " }
                },
                Potencies = new MysteryCursePotency[]
                {
                    new MysteryCursePotency
                    {
                        Id = Guid.Parse("89d439b4-1844-4431-aff0-f86a47037a42"),
                        PotencyId = Potencies.Instances.Minor.ID,
                        Details = new TextBlock[] 
                        { 
                            new TextBlock { Id = Guid.Parse("2380d3fd-169d-4c81-9cae-20ba1ceeec58"), Type = TextBlockType.Text, Text = "One of your ancestors becomes predominant in their meddling. The first time you gain this effect each day, roll 1d4 on Table 2–4: Ancestral Influence to determine which type of ancestor becomes predominant. This predominant ancestor guides you to use their preferred type of action. When you try to use one of the types of actions listed for the other ancestors, you must succeed at a DC 4 flat check. On a failure, you spend the action but gain no effect (though you don't lose the spell if you were Casting a Spell). If your action would take 1 minute or longer, it's long enough that you can overcome the meddling, and you don't need to attempt a flat check." },
                            new TextBlock { Id = Guid.Parse("a5b8f040-c3a0-4974-99fb-7ba38cf48d59"), Type = TextBlockType.Text, Text = "During combat or another tense, round-by-round encounter, other ancestors wrestle for control of your actions. When you roll initiative, and then at the end of each of your turns during the encounter, roll 1d4 and change your predominant ancestor appropriately. Once the encounter ends, you return to the influence of the ancestor you first rolled for the day." }
                        },
                    },
                    new MysteryCursePotency
                    {
                        Id = Guid.Parse("79166a3f-1b4a-490f-85f4-0e56798b68b2"),
                        PotencyId = Potencies.Instances.Moderate.ID,
                        Details = new TextBlock[]
                        {
                            new TextBlock { Id = Guid.Parse("e97a5b8c-045e-4474-96df-3f147ebabf07"), Type = TextBlockType.Text, Text = "The flat check DC to use other actions is 6, and you get the moderate curse benefit listed for your predominant ancestor in Table 2–4." }
                        },
                    },
                    new MysteryCursePotency
                    {
                        Id = Guid.Parse("cda98ae6-3480-41f1-bb85-de92c42feb53"),
                        PotencyId = Potencies.Instances.Major.ID,
                        Details = new TextBlock[]
                        {
                            new TextBlock { Id = Guid.Parse("c4ff4867-633a-4f68-8b4b-9abd318310ce"), Type = TextBlockType.Text, Text = "The flat check DC is 8, and you get the major curse benefit listed for your predominant ancestor instead of the moderate curse benefit." }
                        },
                    }
                },
                Table = new TableBuilder()
                    .AddColumn("084d187b-57f3-4364-9946-b537a876bbb1", "1d4")
                    .AddColumn("9c3847bc-427c-4518-99cf-ab3a57c55f18", "Ancestor")
                    .AddColumn("7b519017-7f2b-4078-9c13-6df639760a85", "Preferred Action")
                    .AddColumn("d0416979-0cb6-4246-8f5e-d7190c0c2a9d", "Moderate Curse Benefit")
                    .AddColumn("62a0f0fb-7a62-4dfb-baaa-9620af146cbd", "Major Curse Benefit")
                    .AddRow("b50e4ff9-fe7a-4f8e-aeb0-71dd0ead28cf", row =>
                    {
                        row
                            .AddCell("d0a595c1-9716-4d19-917f-bb6601aa53a3", "1")
                            .AddCell("fb93a803-978a-4cc0-91c7-3b77180e1f32", "Martial")
                            .AddCell("e34a5411-d557-4e4f-ab32-d34e9f3da7ed", "Strikes")
                            .AddCell("0180f5fc-ea05-430c-8bf8-3e81e9a61987", "Your Strikes gain a +1 status bonus to attack rolls and a +2 status bonus to damage.")
                            .AddCell("d081060c-ad4e-4e8d-a228-a7485d96eb8e", "Your Strikes gain a +1 status bonus to attack rolls and a +6 status bonus to damage.");
                    })
                    .AddRow("69c54485-93ea-427e-bd5f-00d0bbf082eb", row =>
                    {
                        row
                            .AddCell("4ec66e20-9db1-4e9d-9bf4-f8b5a9da2f18", "2")
                            .AddCell("2ba63b75-da35-4672-96db-cd38c9be32bc", "Skillful")
                            .AddCell("a7121bf7-2268-4233-88e8-6dd0a6a8cf0f", "Perception and Skill actions.")
                            .AddCell("5dd26983-42f1-4422-a638-7c30f2b4ec03", "You gain a +1 status bonus to skill checks and Perception checks.")
                            .AddCell("695871c6-235c-457f-af25-3cd9041d7f3b", "You gain a +2 status bonus to skill checks and Perception checks.");
                    })
                    .AddRow("e4a210a5-fee2-41fb-97bc-6244a9c79333", row =>
                    {
                        row
                            .AddCell("184c6df2-95bc-4ca7-a70a-0ccb2f433800", "3")
                            .AddCell("db9d9b8f-243b-4c23-85e0-3bd934caab28", "Spellcasting")
                            .AddCell("242e1c8c-4d80-4511-b382-2bde2a11c077", "Cast a Spell")
                            .AddCell("765217f4-2500-4b7c-aa75-073e48df6735", "Non-cantrip spells without a duration gain a status bonus to their damage and healing equal to the spell's level.")
                            .AddCell("a5398288-2440-4e9e-a94b-41b3674052f8", "Non-cantrip spells without a duration gain a status bonus to their damage and healing equal to the spell's level + 3.");
                    })
                    .AddRow("b68ab4e9-d1a1-488c-a0e9-16d7b72cce61", row =>
                    {
                        row
                            .AddCell("7bf88799-1e3b-4fa3-b67a-710a86800451", "4")
                            .AddCell("d73ae685-0c0a-4f52-9c19-d1c10937fccd", "You choose which ancestor guides your actions.");
                    })
                    .Build("c24ab786-c774-44d0-a404-804ba5399c08")
            };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("81057f28-c6bf-4048-9d93-9fdd12d694e0"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = 73
            };
        }
    }
}
