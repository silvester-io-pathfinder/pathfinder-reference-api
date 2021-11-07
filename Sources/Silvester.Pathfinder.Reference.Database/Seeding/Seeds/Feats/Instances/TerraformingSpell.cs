using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class TerraformingSpell : Template
    {
        public static readonly Guid ID = Guid.Parse("dc855ec6-4610-4cda-a07c-4c251d5a528b");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Terraforming Spell",
                Level = 16,
                ActionTypeId = ActionTypes.Instances.OneAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("a733711b-3166-4f56-9c96-9a7c7afa0635"), Type = TextBlockType.Text, Text = "You capture transformative fragments of magic and slam them into the ground, creating a shock wave that alters your surroundings. If your next action is to Cast a non-cantrip (trait: transmutation) Spell, either each space adjacent to you becomes difficult terrain, or each space adjacent to you is no longer difficult terrain. This doesn’t have any effect on greater difficult terrain and doesn’t remove the damaging effects of hazardous terrain." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("5cba26f1-7566-4200-a4a5-0ae528e6f122"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
