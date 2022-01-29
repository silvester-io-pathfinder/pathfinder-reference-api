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
    public class MinionGuise : Template
    {
        public static readonly Guid ID = Guid.Parse("747df4b0-bacd-4db7-bcd9-cecc3ff2a2bc");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Minion Guise",
                Level = 4,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("9333eb45-c42a-4472-9082-31e305284a34"), Type = TextBlockType.Text, Text = $"When you are in your social identity, you can also grant a social identity to an animal companion, familiar, or other minion you gained from a class feature. When changing to your social identity, you also change your minion's appearance to that of a socially acceptable creature of its type, such as grooming a wolf to appear as a large dog or disguising a familiar to appear as an exotic pet. Commanding your minion to use unusual magical or combat abilities it gained from your class features or feats while in this social identity risks exposing your vigilante identity." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.AddOr(Guid.Parse("891588d1-332f-45d3-9d78-773482a938af"), or => 
            {
                or.HaveSpecificAnimalCompanionAmount(Guid.Parse("2c0d3780-9d96-443e-a327-f51ea4b75c62"), Comparator.GreaterThanOrEqualTo, amount: 1);
                or.HaveAnyFamiliar(Guid.Parse("0ce5055f-a092-4461-861a-d7891087c1ff"));
            });
            builder.HaveSpecificSkillProficiency(Guid.Parse("37aaf1da-1d24-497d-8026-df499a8c3d91"), Proficiencies.Instances.Expert.ID, Skills.Instances.Deception.ID);
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {
            builder.Add(Guid.Parse("498b12f2-3d3c-4e3e-9f79-b9999f076ee0"), Traits.Instances.Archetype.ID);
            builder.Add(Guid.Parse("afd3822a-13b6-47c3-a9dc-2a508bb367bc"), Traits.Instances.Skill.ID);
            builder.Add(Guid.Parse("641084cf-46a6-40c7-a23f-a6885a3bacce"), Traits.Instances.Social.ID);

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("64b54a68-a8ab-41c7-8ee8-cc8f78ec21ff"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
