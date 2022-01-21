using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class PactOfTheFinalBreath : Template
    {
        public static readonly Guid ID = Guid.Parse("4dc4700d-7222-4653-babd-75dd6f9fd7a8");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Pact of The Final Breath",
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
            yield return new TextBlock { Id = Guid.Parse("2a503cf1-086a-4d31-a609-0e3178a03da5"), Type = TextBlockType.Text, Text = "You've sworn a pact with powerful psychopomps—typically an olethros advocate or yamaraj judge—granting you a reprieve before your soul will be collected, in exchange for respect for the dead and assistance against the undead. As long as you keep your end of the bargain, you live twice as long as you normally would before dying of natural causes. Additionally, the first time each day that you would be reduced to 0 Hit Points and gain the dying condition, you instead regain a number of Hit Points equal to your level (starting from 0 HP), remain conscious, and gain fast healing equal to half your level for 3 rounds." };
            yield return new TextBlock { Id = Guid.Parse("3b0f65f7-753f-42e6-a738-c339fab6723d"), Type = TextBlockType.Text, Text = "In exchange, you swear to treat the dead you come across with respect, performing last rites and final dispositions to ensure their spirits rest in peace and are less likely to rise as undead. Furthermore, you swear to destroy undead you come across, so long as it's within your power to do so without inordinate risk to yourself. Violating your part of the pact causes its protections to immediately end. If at that point you had already lived beyond your natural life span, the psychopomps typically give you a few moments to make any last farewells, and then you simply breathe your final breath and pass on." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("adc3d3f2-8149-4416-a9bd-5efa031276d6"),
                SourceId = Sources.Instances.DarkArchive.ID,
                Page = -1
            };
        }
    }
}
