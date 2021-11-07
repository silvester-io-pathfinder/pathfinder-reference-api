using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class ModificationMarvelousGears : Template
    {
        public static readonly Guid ID = Guid.Parse("e0488b60-6a16-4982-a294-8307cb9234a1");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Modification - Marvelous Gears",
                Level = -1,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("23c636b9-0bdb-4dde-b9b1-2b4a27fe7ea2"), Type = TextBlockType.Text, Text = "Your innovation gains expert proficiency in Intimidation, Stealth, and Survival. For any of these skills in which it was already an expert (because of being an advanced construct companion, for example), it gains master proficiency instead. If you have the revolutionary innovation class feature, these proficiencies improve to master, or legendary if your construct innovation was already an expert. You must have the (feat: wonder gears | Modification - Wonder Gears) modification to select this modification." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("202dcfeb-64d3-4c2b-bba7-36efaa049fd9"),
                SourceId = Sources.Instances.GunsAndGears.ID,
                Page = -1
            };
        }
    }
}
