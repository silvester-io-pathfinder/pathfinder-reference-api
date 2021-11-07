using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class SharedAssault : Template
    {
        public static readonly Guid ID = Guid.Parse("5b66d727-50af-4ece-94f3-38c2d1bb6520");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Shared Assault",
                Level = 12,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("d4e22b77-67a2-4771-ab5b-9c7e61e6260b"), Type = TextBlockType.Text, Text = "In the triumph of battle, you can share the glory with another ally. When the ally you chose for (feat: Courageous Assault) critically succeeds at the (action: Strike) granted by that action, another ally affected by your (spell: inspire courage) composition spell can immediately use a reaction to make a melee (action: Strike). Since the second ally wasn’t the ally you chose for (feat: Courageous Assault), this effect doesn’t continue to a third ally, even if the second ally also critically succeeds at their (action: Strike)." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("cd2d9291-849f-4f70-9404-86c9a73e3b2b"), Feats.Instances.CourageousAssault.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("f22bf939-3536-4463-a6ec-fbb48443ae5c"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
