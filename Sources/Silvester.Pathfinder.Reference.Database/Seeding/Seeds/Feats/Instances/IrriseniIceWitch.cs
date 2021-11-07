using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class IrriseniIceWitch : Template
    {
        public static readonly Guid ID = Guid.Parse("e6838751-f5b8-438f-b4c9-6d7fa328025c");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Irriseni Ice-Witch",
                Level = 13,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("f788f90f-c4b0-4780-8931-af2e7da4273c"), Type = TextBlockType.Text, Text = "~ Access: Jadwiga ethnicity" };
            yield return new TextBlock { Id = Guid.Parse("77021bbf-a99e-4388-b04f-cb635bd3b1d2"), Type = TextBlockType.Text, Text = "You can trace your direct descent from one of the Queens of Irrisen and thus from Baba Yaga herself. Your resistance to cold increases to 5 + half your level, and you can cast 5th-level (spell: wall of ice) as an innate arcane spell once per day." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificHeritage(Guid.Parse("5eac0cb1-09a8-49f2-928f-99ae88533db9"), Heritages.Instances.WintertouchedHuman.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("502ee9fb-2d6e-46d5-86b0-cd06efe92992"),
                SourceId = Sources.Instances.LostOmensCharacterGuide.ID,
                Page = -1
            };
        }
    }
}
