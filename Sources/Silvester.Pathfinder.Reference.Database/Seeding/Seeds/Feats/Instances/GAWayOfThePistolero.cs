using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class GAWayOfThePistolero : Template
    {
        public static readonly Guid ID = Guid.Parse("d5fe775a-3841-4f36-b6f1-98d274c5971a");

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
            yield return new TextBlock { Id = Guid.Parse("a70a222a-3880-475d-838b-5974d5f0fd59"), Type = TextBlockType.Text, Text = "Whether you’re a professional duelist or a pistol-twirling entertainer, you have quick feet and quicker hands that never seem to let you down, and an equally sharp wit and tongue that jab your foes. You might leave a hand free or cultivate the ambidexterity for twin weapons. Either way, you stay close enough to your enemies to leverage your superior reflexes while leaving enough space to safely fire." };
            yield return new TextBlock { Id = Guid.Parse("9932016b-772d-4963-8a8c-93006129b854"), Type = TextBlockType.Text, Text = "~ Slinger&#39;s Reload: (feat: Raconteur&#39;s Reload)" };
            yield return new TextBlock { Id = Guid.Parse("1d084ac8-284a-4042-a8f1-e115e0e8ad0d"), Type = TextBlockType.Text, Text = "~ Deeds: __Initial__ (feat: Ten Paces); __Advanced__ (feat: Pistolero’s Retort); __Greater__ (feat: Grim Swagger)" };
            yield return new TextBlock { Id = Guid.Parse("eb0246af-bf17-49d4-b8fb-3ccd11fa5906"), Type = TextBlockType.Text, Text = "~ Way Skill: Deception or Intimidation" };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("1fc08a48-6701-4273-ae19-e0f39aef32b4"),
                SourceId = Sources.Instances.GunsAndGears.ID,
                Page = -1
            };
        }
    }
}
