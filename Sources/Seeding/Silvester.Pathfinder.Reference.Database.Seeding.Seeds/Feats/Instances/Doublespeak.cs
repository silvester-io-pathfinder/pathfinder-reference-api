using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class Doublespeak : Template
    {
        public static readonly Guid ID = Guid.Parse("ebc40853-cd98-481d-9123-f6a742a021b5");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Doublespeak",
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
            yield return new TextBlock { Id = Guid.Parse("be5daeaf-9ae1-4407-a9ff-f5e2b8c99bf6"), Type = TextBlockType.Text, Text = $"You are skilled at saying one thing while meaning something different. You disguise your true meaning behind other words and phrases, relying on subtle emphasis and shared experience to convey meaning that only your allies understand. Any allies who have traveled alongside you for at least 1 full week automatically discern your meaning. Other observers must succeed at a Perception check against your Deception DC to realize you are passing a secret message, and they must critically succeed to understand the message itself." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificSkillProficiency(Guid.Parse("7c7398ee-348b-4586-b9bd-97628424f948"), Proficiencies.Instances.Master.ID, Skills.Instances.Deception.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("e31f285a-f666-408c-b665-e2d4f1aaebda"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
