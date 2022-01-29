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
    public class MountedShield : Template
    {
        public static readonly Guid ID = Guid.Parse("c338e856-3e2a-4597-95ce-5888266c4354");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Mounted Shield",
                Level = 6,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("96d61a8f-633f-4c79-a633-b648a422e7c4"), Type = TextBlockType.Text, Text = $"You've trained with your shield to defend both yourself and your mount. When you {ToMarkdownLink<Models.Entities.Action>("Raise a Shield", Actions.Instances.RaiseAShield.ID)} while mounted, both you and your mount gain the shield's circumstance bonus to AC. If you have the {ToMarkdownLink<Models.Entities.Feat>("Shield Block", Feats.Instances.ShieldBlock.ID)} reaction, you can use it in response to your mount taking damage, as long as you're riding your mount. If you do, the shield prevents your mount from taking damage instead of preventing you from taking damage, following the normal rules for {ToMarkdownLink<Models.Entities.Feat>("Shield Block", Feats.Instances.ShieldBlock.ID)}." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("d7fbdeab-2bd1-4ddd-ae69-9e14f1db4a2a"), Feats.Instances.CavalierDedication.ID);
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {
            builder.Add(Guid.Parse(""), Traits.Instances.Archetype.ID);

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("3087d6a5-c5f2-447d-a25f-1bb9b6a1087f"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
