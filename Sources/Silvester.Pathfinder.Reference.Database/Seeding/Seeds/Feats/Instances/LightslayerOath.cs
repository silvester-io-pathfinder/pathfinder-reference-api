using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class LightslayerOath : Template
    {
        public static readonly Guid ID = Guid.Parse("fc505cfc-b3d6-4fa5-ad42-90a7df99c967");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Lightslayer Oath",
                Level = 2,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("94ebdf9c-236a-4291-9adb-72aeb240ec48"), Type = TextBlockType.Text, Text = "You’ve sworn to rid the world of the self-righteousness of celestial beings. Add the following tenet to your code, after the other tenets. “You must banish or slay celestials you encounter as long as you have a reasonable chance of success; in the incredibly unlikely event you find an evil celestial, you don’t have to banish or kill it.”" };
            yield return new TextBlock { Id = Guid.Parse("dbe6f730-3842-4c3d-a5ba-fcecf5d1d52b"), Type = TextBlockType.Text, Text = "When you use your champion’s reaction against a celestial, the extra damage you deal with (action: Strikes | Strike) increases by 1 (or by 2 at 9th level and by 3 at 16th level)." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificTenet(Guid.Parse("2431e25a-bc11-4e89-b320-ee31baab89b9"), Tenets.Instances.Evil.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("f62c9df3-7929-4ccb-a0a9-ad879b738592"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
