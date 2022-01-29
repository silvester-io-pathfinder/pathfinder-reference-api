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
    public class SigniferArmorExpertise : Template
    {
        public static readonly Guid ID = Guid.Parse("1817f2ce-1b95-4ab3-ac77-c49f8d9a402e");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Signifer Armor Expertise",
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
            yield return new TextBlock { Id = Guid.Parse("23bb74fd-8199-4b3f-be76-c1b0d251411d"), Type = TextBlockType.Text, Text = $"You've spent enough time helping your comrades equip medium and heavy armor that you spread your own expertise to those armors as well. If you have expert proficiency in any armor or unarmored defense, you also gain expert proficiency in medium and heavy armor." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("f4b32033-4ff7-41b3-b1cf-2e25f9ec2716"), Feats.Instances.HellknightSigniferDedication.ID);
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {
            builder.Add(Guid.Parse(""), Traits.Instances.Archetype.ID);

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("8131f646-7308-497b-931f-31649636deba"),
                SourceId = Sources.Instances.LostOmensCharacterGuide.ID,
                Page = -1
            };
        }
    }
}
