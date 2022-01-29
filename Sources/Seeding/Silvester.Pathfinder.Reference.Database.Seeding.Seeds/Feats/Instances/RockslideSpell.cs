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
    public class RockslideSpell : Template
    {
        public static readonly Guid ID = Guid.Parse("80c85871-fd62-441c-8bc1-239a69227912");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Rockslide Spell",
                Level = 10,
                ActionTypeId = ActionTypes.Instances.OneAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("e963c446-d197-4c98-bea8-a3bd03059570"), Type = TextBlockType.Text, Text = $"You enhance your spell with elemental earth, causing chunks of stone to litter the ground. If the next action you use is to {ToMarkdownLink<Models.Entities.Rule>("Cast a non-cantrip Spell", Rules.Instances.CastASpell.ID)} that affects an area, a number of 5-foot squares in the area equal to the spell level become difficult terrain for 1 round. These squares must be on the ground, and the entire area of difficult terrain must be contiguous. The spell gains the {ToMarkdownLink<Models.Entities.Trait>("earth", Traits.Instances.Earth.ID)} trait." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("e8d957bd-0e2d-4b87-ad06-8560d0146f2d"), Feats.Instances.ElementalistDedication.ID);
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("4b209f89-4d41-4920-865b-d2a0f0e2744f"),
                SourceId = Sources.Instances.SecretsOfMagic.ID,
                Page = -1
            };
        }
    }
}
