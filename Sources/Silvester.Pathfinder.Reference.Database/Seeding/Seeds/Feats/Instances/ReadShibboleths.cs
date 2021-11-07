using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class ReadShibboleths : Template
    {
        public static readonly Guid ID = Guid.Parse("f937fa22-a4be-45de-8fff-ef3dd3bd07c8");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Read Shibboleths",
                Level = 7,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("b04cebcd-8a87-424f-ac51-9edc7c4055c2"), Type = TextBlockType.Text, Text = "All communication is filled with slight tells and signals. If you interact with someone for at least 10 minutes, their regional words, pronunciation changes, and nonverbal cues provide you with a minor fact about their social environment, such as their hometown or certain groups they might belong to. If a target of this ability is being deceptive about their social environment, such as a commoner pretending to be a noble, they must attempt a Deception, Society, or appropriate Lore check against your Society DC, providing you a false minor fact consistent with their assumed identity on a success." };
            yield return new TextBlock { Id = Guid.Parse("2968bec3-46c6-487e-b5c1-503cc927fb64"), Type = TextBlockType.Text, Text = "Once you’ve gleaned one or more true minor facts about a person, you can then incorporate these mannerisms into your speech to present yourself in a way that they find familiar. This grants you a +1 circumstance bonus to your Diplomacy and Deception checks with them." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("f95ef408-8cea-4365-815c-9797f453bba8"), Feats.Instances.LinguistDedication.ID);
            builder.HaveSpecificSkillProficiency(Guid.Parse("4e2fc635-809d-4484-ba0f-bf21f56cf47e"), Proficiencies.Instances.Master.ID, Skills.Instances.Society.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("0ab027b4-11b4-43e9-88c7-ed865812c4a8"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
