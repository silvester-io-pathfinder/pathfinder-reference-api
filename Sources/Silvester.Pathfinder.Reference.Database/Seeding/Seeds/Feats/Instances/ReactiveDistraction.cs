using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class ReactiveDistraction : Template
    {
        public static readonly Guid ID = Guid.Parse("10e2cf6f-2b45-450f-8c86-abd55f2aadc7");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Reactive Distraction",
                Level = 20,
                ActionTypeId = ActionTypes.Instances.Reaction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = "You would be hit by an attack or targeted by an effect, or you are within an effect's area.",
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("44560864-2bde-47ec-a61c-3f011cbbf4ee"), Type = TextBlockType.Text, Text = "You reactively switch with your decoy to foil your foe. You use (feat: Perfect Distraction), even if you were observed, as long as you end the movement of your (action: Sneak) while concealed or in a location with cover or greater cover. Your decoy is targeted by the attack or effect instead of you. In the case of an area effect, if your (action: Sneak) doesn’t move you out of the area, both you and the decoy are targeted by the effect." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificSkillProficiency(Guid.Parse("238d1dec-d53c-46a5-a70a-bc4cdcc905f2"), Proficiencies.Instances.Legendary.ID, Skills.Instances.Deception.ID);
            builder.HaveSpecificFeat(Guid.Parse("a4c66d37-e968-4c38-ab07-d96a30174b9e"), Feats.Instances.PerfectDistraction.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("83f17031-c982-4b74-b782-320dd777425c"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = -1
            };
        }
    }
}
