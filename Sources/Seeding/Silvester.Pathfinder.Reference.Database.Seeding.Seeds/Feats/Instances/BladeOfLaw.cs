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
    public class BladeOfLaw : Template
    {
        public static readonly Guid ID = Guid.Parse("48a1fe68-8d85-4825-8bf6-454f4da6020e");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Blade of Law",
                Level = 12,
                ActionTypeId = ActionTypes.Instances.TwoActions.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("137c13a7-f249-49a4-ae17-a86357d4b77f"), Type = TextBlockType.Text, Text = $"You call upon the power of law and make a weapon or unarmed {ToMarkdownLink<Models.Entities.Action>("Strike", Actions.Instances.Strike.ID)} against a foe you have witnessed breaking or disrespecting the law or otherwise acting disorderly. The {ToMarkdownLink<Models.Entities.Action>("Strike", Actions.Instances.Strike.ID)} deals two extra weapon damage dice if the target of your {ToMarkdownLink<Models.Entities.Action>("Strike", Actions.Instances.Strike.ID)} is chaotic. Whether or not the target is chaotic, you can convert the physical damage from the attack into lawful damage." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("d4ba4e9c-52d3-416d-8f3f-66d7aacea6ee"), Feats.Instances.HellknightDedication.ID);
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {
            builder.Add(Guid.Parse(""), Traits.Instances.Archetype.ID);

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("75d23338-3c97-4d0c-a11b-09c8f9cb6362"),
                SourceId = Sources.Instances.LostOmensCharacterGuide.ID,
                Page = -1
            };
        }
    }
}
