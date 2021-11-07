using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class PerfectKiAdept : Template
    {
        public static readonly Guid ID = Guid.Parse("293c8f00-ffa9-44f4-818c-edcb41c6b773");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Perfect Ki Adept",
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
            yield return new TextBlock { Id = Guid.Parse("b41147cd-2d85-4fd3-b7b6-91a3dd65ddb3"), Type = TextBlockType.Text, Text = "You gain the appropriate ki spell for your School of Perfection:" };
            yield return new TextBlock { Id = Guid.Parse("3a56b535-afe5-4b1e-9471-3f22a3b142d6"), Type = TextBlockType.Enumeration, Text = " : (spell: Unblinking flame revelation) for Unblinking Flame" };
            yield return new TextBlock { Id = Guid.Parse("0c9f60d8-73fb-494d-9e25-018b043e9566"), Type = TextBlockType.Enumeration, Text = " : (spell: Unbreaking wave advance) for Unbreaking Waves" };
            yield return new TextBlock { Id = Guid.Parse("7681bb5d-5b6a-4f57-bb26-588937734c1e"), Type = TextBlockType.Enumeration, Text = " : (spell: Unfolding wind rush) for Unfolding Wind" };
            yield return new TextBlock { Id = Guid.Parse("0e4cef5e-d5e4-4e5f-b4cb-5bebdf4057cf"), Type = TextBlockType.Enumeration, Text = " : (spell: Untwisting iron buffer) for Untwisting Iron" };
            yield return new TextBlock { Id = Guid.Parse("d4845ad7-21ba-44e5-af67-f2c16be3fffe"), Type = TextBlockType.Text, Text = "Increase the number of Focus Points in your focus pool by 1." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("a96445a4-0819-40b5-9985-54d2b141d71e"), Feats.Instances.StudentOfPerfectionDedication.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("1f094a55-f171-4874-8c50-f1375d020aff"),
                SourceId = Sources.Instances.LostOmensWorldGuide.ID,
                Page = -1
            };
        }
    }
}
