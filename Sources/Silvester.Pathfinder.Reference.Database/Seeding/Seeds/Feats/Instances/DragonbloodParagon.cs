using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class DragonbloodParagon : Template
    {
        public static readonly Guid ID = Guid.Parse("67d080d9-bbbc-4ecd-8497-aca3a1317f6a");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Dragonblood Paragon",
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
            yield return new TextBlock { Id = Guid.Parse("97e5f65f-0d58-4e35-8dc6-9084c96f172e"), Type = TextBlockType.Text, Text = "Your draconic anatomy becomes especially pronounced. You increase the power of one of the following kobold heritages or feats you have." };
            yield return new TextBlock { Id = Guid.Parse("ccd732d4-6770-4dfe-93aa-278251ce087b"), Type = TextBlockType.Text, Text = "~ Dracomancer: Increase the number of times you can cast each of the granted 1st- and 2nd-level innate spells by 1. " };
            yield return new TextBlock { Id = Guid.Parse("e67855e9-d51e-4f2f-98a4-107cff72d13c"), Type = TextBlockType.Text, Text = "~ Kobold Breath: Creatures that critically fail their save against your (feat: Kobold Breath) take 3d4 persistent damage of the type dealt by your draconic patron." };
            yield return new TextBlock { Id = Guid.Parse("182082c8-5af2-46de-9aa2-b1e989e582ef"), Type = TextBlockType.Text, Text = "~ Strongjaw Kobold: Your jaws unarmed attack gains the (trait: deadly d6) trait." };
            yield return new TextBlock { Id = Guid.Parse("b6f0b8a2-1478-4758-ac67-8db19d04d8ce"), Type = TextBlockType.Text, Text = "~ Venomtail Kobold: You produce enough venom to use the (feat: Tail Toxin) action twice per day." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.AddOr(Guid.Parse("b3c304b5-119b-434d-b3ae-2babecdb0f1f"), or => 
            {
                or.HaveSpecificHeritage(Guid.Parse("85340aa6-b53c-437b-bc55-d9418726f3af"), Heritages.Instances.StrongjawKobold.ID);
                or.HaveSpecificHeritage(Guid.Parse("ba23b5ff-e468-4300-904f-e8389bb6fc97"), Heritages.Instances.VenomtalKobold.ID);
                or.HaveSpecificFeat(Guid.Parse("3c5fb2ae-56fc-4c4e-9fdd-87501749abda"), Feats.Instances.Dracomancer.ID);
                or.HaveSpecificFeat(Guid.Parse("be6f1bdf-35ae-422b-8582-7d2043252900"), Feats.Instances.KoboldBreath.ID);
            });
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("c2dbe5e8-b956-45a4-822d-4f5f86d6e6ee"),
                SourceId = Sources.Instances.LostOmensAncestryGuide.ID,
                Page = -1
            };
        }
    }
}
