using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class StumblingFeint : Template
    {
        public static readonly Guid ID = Guid.Parse("e55db586-68b9-48af-b746-82682c06e3fa");

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
            yield return new TextBlock { Id = Guid.Parse("d2914127-64dd-4502-90cc-c1eba23911cd"), Type = TextBlockType.Text, Text = "You lash out confusingly with what seems to be a weak move but instead allows you to unleash a dangerous flurry of blows upon your unsuspecting foe. When you use (feat: Flurry of Blows), you can attempt a check to (action: Feint) as a free action just before the first (action: Strike). On a success, instead of making the target flat-footed against your next attack, they become flat-footed against both attacks from the (feat: Flurry of Blows)." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificSkillProficiency(Guid.Parse("c29fb2ab-bbf8-474f-8175-a8c54eb4f3d4"), Proficiencies.Instances.Expert.ID, Skills.Instances.Deception.ID);
            builder.HaveSpecificFeat(Guid.Parse("67fa3e49-2a9a-423c-89e6-ad8cf2e2072c"), Feats.Instances.StumblingStance.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("8e11ffc5-c2ad-4409-b008-1b9ee7a98b3e"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
