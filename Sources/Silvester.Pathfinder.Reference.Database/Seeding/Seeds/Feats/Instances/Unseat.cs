using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class Unseat : Template
    {
        public static readonly Guid ID = Guid.Parse("c50b4534-c096-4c37-a64b-a3e84dff4dd9");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Unseat",
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
            yield return new TextBlock { Id = Guid.Parse("19fc50c3-3fb0-4736-8830-dae89aaa968c"), Type = TextBlockType.Text, Text = "You attempt to knock an opponent off their mount. Make a melee (action: Strike) against a mounted opponent. If your attack hits, attempt an Athletics check against the opponent’s Fortitude DC. If you succeed, the foe is knocked off its mount into a space of its choice adjacent to its mount. If you critically succeed, it lands prone." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("4bbbbc39-6fac-4510-99e9-e3a80742ec30"), Feats.Instances.CavalierDedication.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("fa448e70-6473-4439-aada-a4ed7b1a9bde"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
