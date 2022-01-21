using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class BeastDynamoHowl : Template
    {
        public static readonly Guid ID = Guid.Parse("67b7cb87-f71e-44bf-8951-2c71662aea87");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Beast Dynamo Howl",
                Level = 10,
                ActionTypeId = ActionTypes.Instances.TwoActions.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("f8786189-bbe1-41dc-845b-8518ae357fb9"), Type = TextBlockType.Text, Text = $"~ Access: You are from Arcadia." };
            yield return new TextBlock { Id = Guid.Parse("ac2d680c-c0ea-4198-8c6d-c09167be51a7"), Type = TextBlockType.Text, Text = $"You've incorporated beast tech from Arcadia into your dynamo, adding in components from various terrifying creatures to enhance your prosthesis's capabilities. The beast parts can unleash a disturbing howl as you make a powerful attack with your dynamo. Attempt a single Intimidation check to {ToMarkdownLink<Models.Entities.SkillAction>("Demoralize", SkillActions.Instances.Demoralize.ID)} each enemy within 30 feet; you don't take a penalty when you attempt to {ToMarkdownLink<Models.Entities.SkillAction>("Demoralize", SkillActions.Instances.Demoralize.ID)} a creature that doesn't understand your language. Then, make a dynamo {ToMarkdownLink<Models.Entities.Action>("Strike", Actions.Instances.Strike.ID)}. Reduce the operational time of your sterling dynamo by 1 hour." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("3c964e4b-5348-4318-b481-4c18d06f055d"), Feats.Instances.SterlingDynamoDedication.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("1aba0a1e-815c-41c7-9108-5a967b164126"),
                SourceId = Sources.Instances.GunsAndGears.ID,
                Page = -1
            };
        }
    }
}
