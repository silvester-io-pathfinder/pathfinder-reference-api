using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class SteadyingStone : Template
    {
        public static readonly Guid ID = Guid.Parse("b9608169-5863-4b7e-81f0-200502f75162");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Steadying Stone",
                Level = 1,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("4b8a1c67-6f75-470a-87d3-b9f00cce63d2"), Type = TextBlockType.Text, Text = "The earth has taught you how to remain unyielding and firm. If you roll a success on an Acrobatics check made to (action: Balance) on uneven ground composed of earth or rock, you get a critical success instead. As long as you remain on the ground, you gain a +2 circumstance bonus to your Fortitude or Reflex DC against attempts to (action: Shove) or (action: Trip) you. This bonus also applies to saving throws against spells or effects that would attempt to knock you prone. If you're a rock dwarf, this bonus increases to +3." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificDruidicOrder(Guid.Parse("64497906-1ee0-48ee-9ff0-f538f52377da"), DruidicOrders.Instances.Stone.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("96ce6cf2-c07e-49d1-aec9-7fe7d4df72b5"),
                SourceId = Sources.Instances.SecretsOfMagic.ID,
                Page = -1
            };
        }
    }
}
