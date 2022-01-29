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
    public class CeremonyOfFortification : Template
    {
        public static readonly Guid ID = Guid.Parse("f176a22c-f1f5-4e0b-8d16-ffc5d4ac034e");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Ceremony of Fortification",
                Level = 9,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("38830fb9-39ad-4b3b-815f-cfa3d912c79f"), Type = TextBlockType.Text, Text = $"Your exoskeleton arranges itself into an optimal defensive shape. When you use your {ToMarkdownLink<Models.Entities.Feat>("Ceremony of Protection", Feats.Instances.CeremonyOfProtection.ID)}, you also gain resistance to either bludgeoning, piercing, or slashing damage equal to half your level against the next {ToMarkdownLink<Models.Entities.Action>("Strike", Actions.Instances.Strike.ID)} that hits you and deals one of those types of damage until the start of your next turn." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("0312e176-c938-469f-9cc7-9654156677c5"), Feats.Instances.CeremonyOfProtection.ID);
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {
            builder.Add(Guid.Parse("1d01baae-b0c0-49da-90af-96adc309fe86"), Traits.Instances.Conrasu.ID);

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("0206aafa-e3f9-47bd-8a30-53ecebcba339"),
                SourceId = Sources.Instances.LostOmensMwangiExpanse.ID,
                Page = -1
            };
        }
    }
}
