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
        public static readonly Guid ID = Guid.Parse("069c6d19-c101-47ba-9825-5d0e8580edaf");

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
            yield return new TextBlock { Id = Guid.Parse("37cfc543-70db-42f7-8175-11ca7b69febc"), Type = TextBlockType.Text, Text = "You're a sharp-featured, big-eared gnoll about three feet tall. Many are skeptical that you are in fact a gnoll. Your size is Small instead of Medium. You are trained in Deception (or another skill if you were already trained in Deception). You gain a +1 circumstance bonus to Deception checks to Lie when specifically claiming innocence, to Deception DCs against Sense Motive checks to uncover such lies, and to initiative checks when you roll Deception for initiative." };
        }

        protected override void GetEffects(BooleanEffectBuilder builder)
        {
            builder.ModifyAncestrySize(Guid.Parse("b5df7fdb-dd9e-442d-9ac6-49a3acaaba97"), AncestrySizes.Instances.Small.ID);
            builder.AddOr(Guid.Parse("562e6503-109d-49d1-b55b-a8400e534de4"), or => 
            {
                or.GainSpecificSkillProficiency(Guid.Parse("605a8629-23c7-46fe-ae8e-74a7a1229d52"), Proficiencies.Instances.Trained.ID, Skills.Instances.Deception.ID);
                or.GainAnySkillProficiency(Guid.Parse("1793ac8e-2343-4a1f-9797-c38f594a809b"), Proficiencies.Instances.Trained.ID)
                    .AddPrerequisites(Guid.Parse("da4be98e-7065-4e20-958a-129962101b75"), prerequisites => 
                    {
                        prerequisites.HaveSpecificSkillProficiency(Guid.Parse("e08d6f68-e262-4c27-9c5a-b3b47c360ec1"), Proficiencies.Instances.Trained.ID, Skills.Instances.Deception.ID);
                    });
            });

            builder.GainSpecificSkillActionCircumstanceBonus(Guid.Parse("ed0051c4-d40e-4d62-b4b6-0f2000a448c6"), SkillActions.Instances.Lie.ID, bonus: 1, addendum: "Only applies when specifically claiming innocence.");
            builder.GainSpecificSkillSpecificActionDcCircumstanceBonus(Guid.Parse("e45760a0-0c78-40b2-94ab-7e545f204689"), Skills.Instances.Deception.ID, Actions.Instances.SenseMotive.ID, bonus: 1, addendum: "Only applies when specifically claiming innocence.");
            builder.GainSpecificSkillInitiativeCircumstanceBonus(Guid.Parse("5da1433b-cf28-493a-8e19-a05665cc1789"), Skills.Instances.Deception.ID, bonus: 1);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("0a8f648b-34b5-4efa-9635-2722e4418a6e"),
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
