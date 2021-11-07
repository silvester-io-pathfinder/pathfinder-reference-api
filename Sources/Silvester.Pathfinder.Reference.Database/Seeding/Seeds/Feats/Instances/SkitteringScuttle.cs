using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class SkitteringScuttle : Template
    {
        public static readonly Guid ID = Guid.Parse("e46fa45b-0054-4dbc-9511-3be8c0877761");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Skittering Scuttle",
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
            yield return new TextBlock { Id = Guid.Parse("a8ec42cb-1e68-49c5-bf44-5ae3e99587d3"), Type = TextBlockType.Text, Text = "You can scuttle farther and faster when maneuvering alongside allies. When you use (action: Goblin Scuttle), you can (action: Stride) up to half your Speed instead of (action: Stepping | Step)." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("7ed30669-1b27-420e-8064-cb54f4613409"), Feats.Instances.GoblinScuttle.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("3111419c-b889-42a4-a3a2-4c99927519a3"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = -1
            };
        }
    }
}
