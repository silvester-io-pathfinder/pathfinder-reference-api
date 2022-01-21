using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Builders;
using Silvester.Pathfinder.Reference.Database.Effects.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Heritages.Instances
{
    public class FrightfulGoloma : Template
    {
        public static readonly Guid ID = Guid.Parse("b1cd353d-3730-4b7c-885f-62be71b14669");

        protected override Heritage GetHeritage()
        {
            return new Heritage 
            { 
                Id = ID, 
                RarityId = Rarities.Instances.Common.ID, 
                Name = "Frightful Goloma"
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse("920d98a8-8220-4849-888f-27f1ae5caabf"), Type = TextBlockType.Text, Text = "Your face has a particularly off-putting appearance. You are trained in Intimidation (or another skill of your choice if you were already trained in Intimidation) and gain the Intimidating Glare skill feat as a bonus feat." };
        }

        protected override void GetEffects(BooleanEffectBuilder builder)
        {
            builder.AddOr(Guid.Parse("14390df0-39c1-4810-b3d4-54902bfeef57"), or =>
            {
                or.GainSpecificSkillProficiency(Guid.Parse("755f12ef-f8f0-451c-be56-d65cbb8830b7"), Proficiencies.Instances.Trained.ID, Skills.Instances.Intimidation.ID);
                or.GainAnySkillProficiency(Guid.Parse("cab1eb08-4c65-42a5-a944-e822e34d926b"), Proficiencies.Instances.Trained.ID)
                    .AddPrerequisites(Guid.Parse("f9cd0050-4c09-4af4-bb3b-fcb9f264e803"), prerequisites =>
                    {
                        prerequisites.HaveSpecificSkillProficiency(Guid.Parse("b14c92ee-ce89-4660-93cd-86d2b1dba41f"), Proficiencies.Instances.Trained.ID, Skills.Instances.Intimidation.ID);
                    });
            });
            builder.GainSpecificFeat(Guid.Parse("9e852cbe-af2e-4db2-aedb-9ffc674c549d"), Feats.Instances.IntimidatingGlare.ID);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("bac950d6-bf30-4dee-930b-1a68d552eeac"),
                SourceId = Sources.Instances.LostOmensMwangiExpanse.ID,
                Page = 115
            };
        }

        protected override IEnumerable<Guid> GetAncestries()
        {
            yield return Ancestries.Instances.Goloma.ID;
        }
    }
}
