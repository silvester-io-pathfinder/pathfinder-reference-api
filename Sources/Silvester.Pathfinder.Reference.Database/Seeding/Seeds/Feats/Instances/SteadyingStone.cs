using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class SteadyingStone : Template
    {
        public static readonly Guid ID = Guid.Parse("99b412f8-4fc2-4a3f-b3b4-64ff97e1d9a8");

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
            yield return new TextBlock { Id = Guid.Parse("7f83160a-5745-49d3-bf62-3716b961d9da"), Type = TextBlockType.Text, Text = "The earth has taught you how to remain unyielding and firm. If you roll a success on an Acrobatics check made to (action: Balance) on uneven ground composed of earth or rock, you get a critical success instead. As long as you remain on the ground, you gain a +2 circumstance bonus to your Fortitude or Reflex DC against attempts to (action: Shove) or (action: Trip) you. This bonus also applies to saving throws against spells or effects that would attempt to knock you prone. If you’re a rock dwarf, this bonus increases to +3." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificDruidicOrder(Guid.Parse("c6ea5d86-7aa8-4a8c-9a6d-366765dfc478"), DruidicOrders.Instances.Stone.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("bdac4d2e-1068-4d61-9502-f95d9f164f8c"),
                SourceId = Sources.Instances.SecretsOfMagic.ID,
                Page = -1
            };
        }
    }
}
