using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class MentalBalm : Template
    {
        public static readonly Guid ID = Guid.Parse("5e3194b7-7bf3-4bbb-8f9b-ec26f9da38ba");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Mental Balm",
                Level = 2,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("f5f233a2-5407-4c3f-8371-11aac21f3b06"), Type = TextBlockType.Text, Text = "As your psychic magic flares, you release soothing mental waves to stabilize the mind. Use this amp in place of the psi cantrip’s normal amp entry. You can use this amp only on a psi cantrip that targets or affects one or more of your allies and doesn’t target or affect any enemies." };
            yield return new TextBlock { Id = Guid.Parse("811f231d-183f-457c-ba5e-ba6ff2c245af"), Type = TextBlockType.Text, Text = "----" };
            yield return new TextBlock { Id = Guid.Parse("9d103400-105b-450d-95cc-5ff96eddbe4d"), Type = TextBlockType.Text, Text = "~ Amp: You or one ally within 30 feet gain a +1 bonus to Will saves against (trait: emotion) effects for 1 round. You can also have the amped psi cantrip attempt to counteract one effect on yourself or the chosen ally imposing the frightened condition, or an effect imposing the stupefied condition that has a duration of 1 hour or less. On a success, you end the frightened and stupefied conditions, but you don’t end any other parts of the effect, if any." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("a56d8d55-b403-484f-b570-742dff249d4e"),
                SourceId = Sources.Instances.DarkArchive.ID,
                Page = -1
            };
        }
    }
}
