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
        public static readonly Guid ID = Guid.Parse("");

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
            yield return new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Text, Text = "The voices of generations past speak to you, and you hear their words. You might resent the constant interruption, or you might revere the spirits of those who came before. Perhaps you hail from a culture with strong ancestral traditions, such as the Shoanti Skoan-Quah (Skull Clan), a traditional dwarven community that worships Torag's family pantheon, or a group that reveres Erastil or Pharasma. You might commune with powerful psychopomps who shepherd souls to the afterlife, with the River of Souls itself, or with those spirits who have become trapped outside of the great cycle of spiritual rebirth. You learn from their whispers and the fragments of their memories, but opening your mind to their knowledge and experience also allows them to meddle in your worldly affairs." };
        }

        protected override IEnumerable<TextBlock> GetBenefitBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Text, Text = "The whispers of your ancestors have bestowed additional knowledge upon you. You gain an additional ancestry feat at 1st level and another additional ancestry feat at 11th level. These feats can't be ones that grant physiological effects, such as additional senses or unarmed attacks." };
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
                Id = Guid.Parse(""),
                Name = "Curse of Ancestral Meddling",
                SourcePage = new SourcePage
                {
                    Id = Guid.Parse(""),
                    SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                    Page = 73
                },
                Details = new TextBlock[]
                {
                    new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Text, Text = "The ancestral spirits you commune with haunt you and meddle with your belongings and actions, either out of a well-intentioned (but ultimately detrimental) attempt to assist you, as punishment for your audacity in circumventing the traditional means of achieving divine power, for their own amusement, or a mixture of the above. Your hair, clothing, and belongings constantly shift and stir, seemingly of their own volition. " }
                },
                Potencies = new MysteryCursePotency[]
                {
                    new MysteryCursePotency
                    {
                        Id = Guid.Parse(""),
                        PotencyId = Potencies.Instances.Minor.ID,
                        Details = new TextBlock[] 
                        { 
                            new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Text, Text = "One of your ancestors becomes predominant in their meddling. The first time you gain this effect each day, roll 1d4 on Table 2–4: Ancestral Influence to determine which type of ancestor becomes predominant. This predominant ancestor guides you to use their preferred type of action. When you try to use one of the types of actions listed for the other ancestors, you must succeed at a DC 4 flat check. On a failure, you spend the action but gain no effect (though you don't lose the spell if you were Casting a Spell). If your action would take 1 minute or longer, it's long enough that you can overcome the meddling, and you don't need to attempt a flat check." },
                            new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Text, Text = "During combat or another tense, round-by-round encounter, other ancestors wrestle for control of your actions. When you roll initiative, and then at the end of each of your turns during the encounter, roll 1d4 and change your predominant ancestor appropriately. Once the encounter ends, you return to the influence of the ancestor you first rolled for the day." }
                        },
                    },
                    new MysteryCursePotency
                    {
                        Id = Guid.Parse(""),
                        PotencyId = Potencies.Instances.Moderate.ID,
                        Details = new TextBlock[]
                        {
                            new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Text, Text = "The flat check DC to use other actions is 6, and you get the moderate curse benefit listed for your predominant ancestor in Table 2–4." }
                        },
                    },
                    new MysteryCursePotency
                    {
                        Id = Guid.Parse(""),
                        PotencyId = Potencies.Instances.Major.ID,
                        Details = new TextBlock[]
                        {
                            new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Text, Text = "The flat check DC is 8, and you get the major curse benefit listed for your predominant ancestor instead of the moderate curse benefit." }
                        },
                    }
                },
                Table = new TableBuilder()
                    .AddColumn("", "1d4")
                    .AddColumn("", "Ancestor")
                    .AddColumn("", "Preferred Action")
                    .AddColumn("", "Moderate Curse Benefit")
                    .AddColumn("", "Major Curse Benefit")
                    .AddRow("", row =>
                    {
                        row
                            .AddCell("", "1")
                            .AddCell("", "Martial")
                            .AddCell("", "Strikes")
                            .AddCell("", "Your Strikes gain a +1 status bonus to attack rolls and a +2 status bonus to damage.")
                            .AddCell("", "Your Strikes gain a +1 status bonus to attack rolls and a +6 status bonus to damage.");
                    })
                    .AddRow("", row =>
                    {
                        row
                            .AddCell("", "2")
                            .AddCell("", "Skillful")
                            .AddCell("", "Perception and Skill actions.")
                            .AddCell("", "You gain a +1 status bonus to skill checks and Perception checks.")
                            .AddCell("", "You gain a +2 status bonus to skill checks and Perception checks.");
                    })
                    .AddRow("", row =>
                    {
                        row
                            .AddCell("", "3")
                            .AddCell("", "Spellcasting")
                            .AddCell("", "Cast a Spell")
                            .AddCell("", "Non-cantrip spells without a duration gain a status bonus to their damage and healing equal to the spell's level.")
                            .AddCell("", "Non-cantrip spells without a duration gain a status bonus to their damage and healing equal to the spell's level + 3.");
                    })
                    .AddRow("", row =>
                    {
                        row
                            .AddCell("", "4")
                            .AddCell("", "You choose which ancestor guides your actions.");
                    })
                    .Build("")
            };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse(""),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = 73
            };
        }
    }
}
