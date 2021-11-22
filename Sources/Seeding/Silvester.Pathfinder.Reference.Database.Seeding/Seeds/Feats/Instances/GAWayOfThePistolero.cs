using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class GAWayOfThePistolero : Template
    {
        public static readonly Guid ID = Guid.Parse("4f5c59e1-01cd-42c8-82de-ddc638a83ce9");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "GA - Way of the Pistolero",
                Level = -1,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("32974962-cb5f-4115-98f4-b00c0b789ecb"), Type = TextBlockType.Text, Text = "Whether you're a professional duelist or a pistol-twirling entertainer, you have quick feet and quicker hands that never seem to let you down, and an equally sharp wit and tongue that jab your foes. You might leave a hand free or cultivate the ambidexterity for twin weapons. Either way, you stay close enough to your enemies to leverage your superior reflexes while leaving enough space to safely fire." };
            yield return new TextBlock { Id = Guid.Parse("a8ddeca6-f541-4fee-9d75-6c4b32a7ca3a"), Type = TextBlockType.Text, Text = "~ Slinger's Reload: (feat: Raconteur's Reload)" };
            yield return new TextBlock { Id = Guid.Parse("bd3b5eed-c2b6-4ca5-832a-e629b87c355e"), Type = TextBlockType.Text, Text = "~ Deeds: __Initial__ (feat: Ten Paces); __Advanced__ (feat: Pistolero's Retort); __Greater__ (feat: Grim Swagger)" };
            yield return new TextBlock { Id = Guid.Parse("bb258232-6fbd-4f84-8da8-636c9a160f7f"), Type = TextBlockType.Text, Text = "~ Way Skill: Deception or Intimidation" };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("ec8cc190-7b02-4b8c-84da-441522adcb6d"),
                SourceId = Sources.Instances.GunsAndGears.ID,
                Page = -1
            };
        }
    }
}
