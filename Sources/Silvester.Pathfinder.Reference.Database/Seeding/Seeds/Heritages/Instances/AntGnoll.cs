using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Ancestries.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Builders;
using Silvester.Pathfinder.Reference.Database.Effects.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Heritages.Instances
{
    public class AntGnoll : Template
    {
        public static readonly Guid ID = Guid.Parse("");

        protected override Heritage GetHeritage()
        {
            return new Heritage 
            { 
                Id = ID, 
                RarityId = Rarities.Instances.Common.ID, 
                Name = "Ant Gnoll"
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Text, Text = "You're a sharp-featured, big-eared gnoll about three feet tall. Many are skeptical that you are in fact a gnoll. Your size is Small instead of Medium. You are trained in Deception (or another skill if you were already trained in Deception). You gain a +1 circumstance bonus to Deception checks to Lie when specifically claiming innocence, to Deception DCs against Sense Motive checks to uncover such lies, and to initiative checks when you roll Deception for initiative." };
        }

        protected override void GetEffects(BooleanEffectBuilder builder)
        {
            builder.ModifyAncestrySize(Guid.Parse(""), AncestrySizes.Instances.Small.ID);
            builder.AddOr(Guid.Parse(""), or => 
            {
                or.GainSpecificSkillProficiency(Guid.Parse(""), Proficiencies.Instances.Trained.ID, Skills.Instances.Deception.ID);
                or.GainAnySkillProficiency(Guid.Parse(""), Proficiencies.Instances.Trained.ID)
                    .AddPrerequisites(Guid.Parse(""), prerequisites => 
                    {
                        prerequisites.HaveSpecificSkillProficiency(Guid.Parse(""), Proficiencies.Instances.Trained.ID, Skills.Instances.Deception.ID);
                    });
            });

            builder.GainSpecificSkillActionCircumstanceBonus(Guid.Parse(""), SkillActions.Instances.Lie.ID, bonus: 1, addendum: "Only applies when specifically claiming innocence.");
            builder.GainSpecificSkillSpecificSkillActionDcCircumstanceBonus(Guid.Parse(""), Skills.Instances.Deception.ID, Actions.Instances.SenseMotive.ID, bonus: 1, addendum: "Only applies when specifically claiming innocence.");
            builder.GainSpecificSkillInitiativeCircumstanceBonus(Guid.Parse(""), Skills.Instances.Deception.ID, bonus: 1);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse(""),
                SourceId = Sources.Instances.LostOmensMwangiExpanse.ID,
                Page = 111
            };
        }

        protected override IEnumerable<Guid> GetAncestries()
        {
            yield return Gnoll.ID;
        }
    }
}
