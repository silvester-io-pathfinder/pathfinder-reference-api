using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class DeviseAStratagem : Template
    {
        public static readonly Guid ID = Guid.Parse("136917ff-4910-44a8-b267-652e6c3cddc8");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Devise a Stratagem",
                Level = -1,
                ActionTypeId = ActionTypes.Instances.OneAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = "once per round"
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("b4bb173a-d364-40b0-9d5f-23c63770224a"), Type = TextBlockType.Text, Text = "You assess a foe&#39;s weaknesses in combat and use them to formulate a plan of attack against your enemy. Choose a creature you can see and roll a d20. If you (action: Strike) the chosen creature later this round, you must use the result of the roll you made to Devise a Stratagem for your (action: Strike)&#39;s attack roll instead of rolling. You make this substitution only for the first (action: Strike) you make against the creature this round, not any subsequent attacks." };
            yield return new TextBlock { Id = Guid.Parse("b7b80137-694c-4c84-9311-6b509a6ae237"), Type = TextBlockType.Text, Text = "When you make this substitution, you can also add your Intelligence modifier to your attack roll instead of your Strength or Dexterity modifier, provided your (action: Strike) uses an (trait: agile) or (trait: finesse) melee weapon, an (trait: agile) or (trait: finesse) unarmed attack, a ranged weapon (which must be (trait: agile) or (trait: finesse) if it&#39;s a melee weapon with the (trait: thrown) trait), or a (item: sap)." };
            yield return new TextBlock { Id = Guid.Parse("d260d8e2-4d24-4ada-b349-a6c32711b99b"), Type = TextBlockType.Text, Text = "If you&#39;re aware that the creature you choose is the subject of a lead you&#39;re pursuing, you can use this ability as a free action." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("dc9f1a8f-dda9-494c-b7ec-c22fa5280fc0"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
