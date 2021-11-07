using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class StumblingFeint : Template
    {
        public static readonly Guid ID = Guid.Parse("8f431c57-ec65-4292-bc60-1346d9c2ae2a");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Stumbling Feint",
                Level = 6,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("cd5eed67-8d43-49fd-95fa-83dbe7f4099c"), Type = TextBlockType.Text, Text = "You lash out confusingly with what seems to be a weak move but instead allows you to unleash a dangerous flurry of blows upon your unsuspecting foe. When you use (feat: Flurry of Blows), you can attempt a check to (action: Feint) as a free action just before the first (action: Strike). On a success, instead of making the target flat-footed against your next attack, they become flat-footed against both attacks from the (feat: Flurry of Blows)." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificSkillProficiency(Guid.Parse("3669e2e7-ac78-46bb-a8ce-810314f1915b"), Proficiencies.Instances.Expert.ID, Skills.Instances.Deception.ID);
            builder.HaveSpecificFeat(Guid.Parse("b88292ff-f251-4415-93c2-b55ecf153077"), Feats.Instances.StumblingStance.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("6dd523f1-39ab-4132-b166-a13b89c27535"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
