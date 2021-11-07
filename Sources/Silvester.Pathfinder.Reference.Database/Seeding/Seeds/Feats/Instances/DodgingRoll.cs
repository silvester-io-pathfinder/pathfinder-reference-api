using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class DodgingRoll : Template
    {
        public static readonly Guid ID = Guid.Parse("91a113ef-ca55-4709-acdc-aa4311eac57c");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Dodging Roll",
                Level = 12,
                ActionTypeId = ActionTypes.Instances.Reaction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = "You take damage from an area effect that allows a Reflex save.",
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("7e38a8a8-24d6-4589-8867-47b2ed076f4e"), Type = TextBlockType.Text, Text = "You dodge a blow at the last possible moment. You (action: Step) and gain resistance to all damage equal to your level against the triggering effect. If your (action: Step) moves you out of the triggering effect’s area, this resistance is instead equal to your level plus your Dexterity modifier." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificSkillProficiency(Guid.Parse("18f515d7-1873-4a9c-b1a8-5f81ed268bec"), Proficiencies.Instances.Master.ID, Skills.Instances.Acrobatics.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("28e77441-eb5f-40ed-8782-db465f014f78"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
