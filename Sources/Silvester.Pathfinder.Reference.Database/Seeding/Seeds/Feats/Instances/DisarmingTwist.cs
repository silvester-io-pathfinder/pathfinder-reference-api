using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class DisarmingTwist : Template
    {
        public static readonly Guid ID = Guid.Parse("e31835f4-8532-4ade-981b-3a3db1fcc9b9");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Disarming Twist",
                Level = 12,
                ActionTypeId = ActionTypes.Instances.OneAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("05d6ea37-1fdd-4ece-9380-34506e2ecc4c"), Type = TextBlockType.Text, Text = "After your initial attack redirects your foe’s defenses, your follow-up wrests their weapon from their grasp. Make a melee (action: Strike) with the required weapon. In addition to its other effects, this (action: Strike) gains the success and critical success effects of the (action: Disarm) action. The (action: Strike) also has the following failure effect." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("48f13a7d-3153-49c2-95b6-6cc337011912"), Feats.Instances.DuelistDedication.ID);
            builder.HaveSpecificSkillProficiency(Guid.Parse("0109ebd4-0e76-4fae-97e0-08879db22ade"), Proficiencies.Instances.Trained.ID, Skills.Instances.Athletics.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }

        protected override RollableEffect? GetRollableEffect()
        {
            return new RollableEffect
            {
                Id = Guid.Parse("11690f3d-3d89-40da-8062-341b1fc7d076"),
                
                
                Failure = "The target is flat-footed until the end of your current turn.",
                 
            };
        }
            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("ca38b96b-55dc-4e0f-ab05-b07f797a9561"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
