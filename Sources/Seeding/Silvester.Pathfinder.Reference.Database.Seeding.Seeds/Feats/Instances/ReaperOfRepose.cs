using Silvester.Pathfinder.Reference.Database.Seeding.Builders.TextBlocks;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.Traits;
using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class ReaperOfRepose : Template
    {
        public static readonly Guid ID = Guid.Parse("8787cdf9-f6fe-45be-a870-85f0a56b01f5");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Reaper of Repose",
                Level = 12,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("883c2fcf-7f6a-4d3c-8626-bf0f273cf2d2"), Type = TextBlockType.Text, Text = $"Your skill and fervor allow you to pierce undead defenses and exploit their weaknesses. When you make an attack using a weapon with which you have master proficiency and hit an undead creature, you ignore 5 points of the creature's resistances, and the undead's weaknesses are 2 higher against your attack." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("f4c1ff8c-8fb0-4689-8e59-7f871a1584a8"), Feats.Instances.KnightReclaimantDedication.ID);
            builder.AddOr(Guid.Parse("f848ab92-8958-4868-b99d-dd0e080e7bb7"), or => 
            {
                or.HaveAnyWeaponCategorySpecificProficiency(Guid.Parse("cda0ca19-c560-451d-893e-7abd20da8b23"), Proficiencies.Instances.Master.ID);
                or.HaveAnyWeaponGroupSpecificProficiency(Guid.Parse("8e84a9d8-0ed1-47a1-b24a-0c6f6fafd963"), Proficiencies.Instances.Master.ID);
                or.HaveAnyMeleeWeaponSpecificProficiency(Guid.Parse("5f3d3077-be9f-42eb-8398-e0d18e250b90"), Proficiencies.Instances.Master.ID);
                or.HaveAnyRangedWeaponSpecificProficiency(Guid.Parse("6e1c6559-caf6-4a1c-bcf4-8613235745bf"), Proficiencies.Instances.Master.ID);
            });
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {
            builder.Add(Guid.Parse(""), Traits.Instances.Archetype.ID);

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("8026b209-114e-4f83-a404-d768a5c671e2"),
                SourceId = Sources.Instances.LostOmensCharacterGuide.ID,
                Page = -1
            };
        }
    }
}
