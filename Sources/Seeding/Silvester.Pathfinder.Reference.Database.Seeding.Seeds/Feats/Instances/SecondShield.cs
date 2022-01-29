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
    public class SecondShield : Template
    {
        public static readonly Guid ID = Guid.Parse("d5fb29c4-7c9b-4ada-ae02-16fd556f8909");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Second Shield",
                Level = 6,
                ActionTypeId = ActionTypes.Instances.FreeAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = "Your Shield Block causes your shield to break or be destroyed.",
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("f0f2bf06-bcdc-4ecd-adc0-b863ccf72cb5"), Type = TextBlockType.Text, Text = $"You're used to your shield breaking in the middle of battle, and you're prepared to use a backup or any convenient nearby object to defend yourself. You can {ToMarkdownLink<Models.Entities.Action>("Interact", Actions.Instances.Interact.ID)} to draw a shield on your person or an unattended shield within your reach. If there is an object within your reach that could serve as an improvised shield – for example, a table or chair – you can {ToMarkdownLink<Models.Entities.Action>("Interact", Actions.Instances.Interact.ID)} to draw it with this feat. The GM determines if something can be used as an improvised shield. Your new shield isn't raised until you use the {ToMarkdownLink<Models.Entities.Action>("Raise a Shield", Actions.Instances.RaiseAShield.ID)} action, as normal." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("01a03021-fd16-4a85-9bcd-1b4ae74a4f71"), Feats.Instances.VikingDedication.ID);
            builder.HaveSpecificFeat(Guid.Parse("64ff06d0-6efc-4bb9-8f07-95444bd6822e"), Feats.Instances.ShieldBlock.ID);
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {
            builder.Add(Guid.Parse(""), Traits.Instances.Archetype.ID);

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("2ebe881d-be45-4be7-a510-301f43ffcf8c"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
