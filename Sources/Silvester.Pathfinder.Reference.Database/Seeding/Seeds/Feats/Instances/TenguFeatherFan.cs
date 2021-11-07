using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class TenguFeatherFan : Template
    {
        public static readonly Guid ID = Guid.Parse("20298ced-7a12-414a-b616-fe45e3c830f9");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Tengu Feather Fan",
                Level = 5,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("be05f7ba-c7f3-49a6-b6f7-ecf24c018d86"), Type = TextBlockType.Text, Text = "You’ve learned to bind some of your feathers together into a fan to focus your ancestral magic. You gain a (item: tengu feather fan): a magic item of light Bulk with a level equal to your level and the (trait: evocation) and (trait: primal) traits. You (and only you) can use the (item: tengu feather fan) to cast tengu magic. If your fan is lost or destroyed, you can create a replacement during your daily preparations; if you do so, your previous fan falls apart into mundane feathers. Further feats might grant you additional activations of your (item: tengu feather fan), but you can never have more than three activations per day, no matter how many such feats you have. The DC for spells you cast with your (item: tengu feather fan) is your class DC or spell DC, whichever is higher." };
            yield return new TextBlock { Id = Guid.Parse("ce27e01a-c972-4fd5-8f14-d832f1fecba2"), Type = TextBlockType.Text, Text = "You can cast the 1st-level (spell: gust of wind) spell by activating your (item: tengu feather fan)." };
            yield return new TextBlock { Id = Guid.Parse("1b20cc5a-9b0b-4fb9-8bca-4dda328379d3"), Type = TextBlockType.Text, Text = "~ Activate: (action: Interact); **Frequency** once per day; **Effect** You cast one of the spells contained in your tengu feather fan. Activating the fan takes the spell’s normal number of actions. You can also Activate the fan to cast a cantrip you’ve gained from a heritage or ancestry feat; this activation doesn’t count against the fan’s uses per day." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("92dbc1b8-6dcb-478a-8eb5-fe4dc6a75e50"),
                SourceId = Sources.Instances.LostOmensAncestryGuide.ID,
                Page = -1
            };
        }
    }
}
