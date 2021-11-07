using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class PerfectionsPath : Template
    {
        public static readonly Guid ID = Guid.Parse("492ec808-2925-484a-8f10-7f425744ee57");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Perfection's Path",
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
            yield return new TextBlock { Id = Guid.Parse("dd78dd57-798f-4978-b4a8-b258c94475a7"), Type = TextBlockType.Text, Text = "Choose one saving throw (Fortitude, Reflex, or Will) in which you are an expert. Your proficiency rank in the chosen saving throw increases to master." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveAnySavingThrowSpecificProficiency(Guid.Parse("8645c7a7-9c2d-4f7e-8b61-6e1efa78a30e"), Proficiencies.Instances.Expert.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("a6b0e1ae-a442-4372-9492-fa7f4a501e86"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = -1
            };
        }
    }
}
