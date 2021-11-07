using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class CoreAttunement : Template
    {
        public static readonly Guid ID = Guid.Parse("e0eecef1-3431-45fd-b130-797b8e6bc6bf");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Core Attunement",
                Level = 9,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("a254b450-0f46-4683-b84d-12eb44808c01"), Type = TextBlockType.Text, Text = "Your core allows you to draw more power from it. Select one 1st-level arcane spell and one 2nd-level or lower arcane spell, to which you have access. You can cast your chosen spells as arcane innate spells each once per day." };
            yield return new TextBlock { Id = Guid.Parse("238dd5c3-813a-454f-bb9a-400cc5c99402"), Type = TextBlockType.Text, Text = "----" };
            yield return new TextBlock { Id = Guid.Parse("adbdb980-8fec-4f32-94d9-190b2c3793f8"), Type = TextBlockType.Text, Text = "~ Enhancement: Your attunement grows stronger. Select one 5th-level or lower arcane spell and one 6th-level or lower arcane spell, to which you have access. You can cast them as arcane innate spells each once per day, in addition to the original spells." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificHeritage(Guid.Parse("ceebfc0d-7210-47fe-85af-d31086cf846b"), Heritages.Instances.MageAutomaton.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("3d47be40-c8bf-4979-a706-c2b9045d5108"),
                SourceId = Sources.Instances.GunsAndGears.ID,
                Page = -1
            };
        }
    }
}
