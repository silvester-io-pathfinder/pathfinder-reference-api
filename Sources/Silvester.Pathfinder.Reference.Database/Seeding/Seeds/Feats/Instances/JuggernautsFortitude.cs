using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class JuggernautsFortitude : Template
    {
        public static readonly Guid ID = Guid.Parse("0a71ca17-d420-4733-a34b-5058fe8b88d8");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Juggernaut's Fortitude",
                Level = 12,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("155631ae-f114-44fd-8759-9f98dd28c30a"), Type = TextBlockType.Text, Text = "Your proficiency rank in Fortitude saves increases to master." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("c36d6d27-aed4-48db-b4bf-8891fb8d9466"), Feats.Instances.BarbarianDedication.ID);
            builder.HaveSpecificSavingThrowSpecificProficiency(Guid.Parse("90fd753c-9656-47aa-8456-4cf8bb711a0e"), Proficiencies.Instances.Expert.ID, SavingThrowStats.Instances.Fortitude.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("3d1d9367-6410-4c11-b6dd-530e4f081e8a"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = -1
            };
        }
    }
}
