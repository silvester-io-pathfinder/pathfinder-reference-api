using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class EnigmasKnowledge : Template
    {
        public static readonly Guid ID = Guid.Parse("c336744e-e36e-4c50-add6-de2fd83f9fb0");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Enigma's Knowledge",
                Level = 14,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("f3053991-2f7a-40c0-96a2-541aa8e7e9e0"), Type = TextBlockType.Text, Text = "Your muse whispers knowledge to you at all the right times. You gain the benefits of the (feat: Automatic Knowledge) skill feat with any skill you can use to (action: Recall Knowledge). As per the special clause in the (feat: Automatic Knowledge) feat, you can still only use (feat: Automatic Knowledge) once per round." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("ec548558-2e2f-4e13-a4ca-235cae3903a5"), Feats.Instances.AssuredKnowledge.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("eab672aa-65d0-4d0c-aab8-5f5feae9188a"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
