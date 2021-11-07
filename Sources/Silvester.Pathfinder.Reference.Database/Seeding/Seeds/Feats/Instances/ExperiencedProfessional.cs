using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class ExperiencedProfessional : Template
    {
        public static readonly Guid ID = Guid.Parse("81e8e011-9c55-4bc2-a341-360a8f82f6c5");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Experienced Professional",
                Level = 1,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("46f70fd3-fbf8-4796-961a-4185caf771f1"), Type = TextBlockType.Text, Text = "You carefully safeguard your professional endeavors to prevent disaster. When you use Lore to (action: Earn Income), if you roll a critical failure, you instead get a failure. If you’re an expert in Lore, you gain twice as much income from a failed check to (action: Earn Income), unless it was originally a critical failure." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveAnyLoreProficiency(Guid.Parse("06eb9af5-3a5c-4a22-affa-f461ed944b21"), Proficiencies.Instances.Trained.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("cfb75f61-82e8-4b61-af6b-600f32021e63"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = -1
            };
        }
    }
}
