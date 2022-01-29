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
    public class WitchsCharge : Template
    {
        public static readonly Guid ID = Guid.Parse("02e16a28-d855-4a66-a580-e6a6d8fd906a");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Witch's Charge",
                Level = 6,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = "This feat has the trait corresponding to the tradition of spells you cast ((trait: arcane), (trait: divine), (trait: occult), or (trait: primal)).",
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("3375b3d6-5ee4-4985-a459-47faec5dc7fe"), Type = TextBlockType.Text, Text = $"You forge a magical link with another creature, granting you awareness of that creature's condition and creating a conduit for spellcasting. During your daily preparations, you can designate one willing creature as your charge. You are always aware of your charge's direction from you, its distance from you, and any conditions affecting it. In addition, you can cast spells with a range of touch on your charge from a range of 30 feet. These effects persist until your next daily preparations." };
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {
            builder.Add(Guid.Parse(""), Traits.Instances.Detection.ID);
            builder.Add(Guid.Parse(""), Traits.Instances.Divination.ID);
            builder.Add(Guid.Parse(""), Traits.Instances.Witch.ID);

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("99823abf-fd39-458e-95e6-97a52d77d47a"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
