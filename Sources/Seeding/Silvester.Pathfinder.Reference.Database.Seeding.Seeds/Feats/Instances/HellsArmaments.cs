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
    public class HellsArmaments : Template
    {
        public static readonly Guid ID = Guid.Parse("d1ae72b2-9494-4dfb-8f24-9ab9b15a2edc");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Hell's Armaments",
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
            yield return new TextBlock { Id = Guid.Parse("67d6d66d-8645-43d7-b5ef-46c1f6861e07"), Type = TextBlockType.Text, Text = $"You've trained with your order's weapon and your Hellknight plate long enough to apply your expertise from other weapons and armor. If you have expert proficiency in any weapon or unarmed attack, you gain expert proficiency in your order's weapon as well. If you have expert proficiency in any armor or unarmored defense, you gain expert proficiency in Hellknight plate as well." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("5298fa29-09cc-4e69-bdbc-97746a37cf42"), Feats.Instances.HellknightDedication.ID);
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {
            builder.Add(Guid.Parse(""), Traits.Instances.Archetype.ID);

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("6d1aa123-2ec6-4c4b-9812-edd0654c89ec"),
                SourceId = Sources.Instances.LostOmensCharacterGuide.ID,
                Page = -1
            };
        }
    }
}
