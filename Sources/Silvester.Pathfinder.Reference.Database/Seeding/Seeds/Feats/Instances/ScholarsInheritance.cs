using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class ScholarsInheritance : Template
    {
        public static readonly Guid ID = Guid.Parse("6d4b2346-567c-485e-9373-7b30beb5dae6");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Scholar's Inheritance",
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
            yield return new TextBlock { Id = Guid.Parse("6e4c5753-3cd2-4b6d-9407-813106410a42"), Type = TextBlockType.Text, Text = "Your parents devoted themselves to alchemical experiments involving elemental energy. You gain the trained proficiency rank in Crafting. If you would automatically become trained in Crafting (from your background or class, for example), you instead become trained in a skill of your choice. You also gain the (feat: Alchemical Crafting) skill feat." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("31cec9b6-224e-41bf-8f82-7758de9d6dbf"),
                SourceId = Sources.Instances.LostOmensAncestryGuide.ID,
                Page = -1
            };
        }
    }
}
