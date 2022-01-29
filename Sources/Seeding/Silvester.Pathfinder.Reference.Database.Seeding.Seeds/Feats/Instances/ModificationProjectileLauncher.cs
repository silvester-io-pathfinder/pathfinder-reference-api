using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class ModificationProjectileLauncher : Template
    {
        public static readonly Guid ID = Guid.Parse("6a8a99db-7fc9-472c-9dda-a0975cf94509");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Modification - Projectile Launcher",
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
            yield return new TextBlock { Id = Guid.Parse("2a245bbe-5e8f-4df0-9450-ced1df94df81"), Type = TextBlockType.Text, Text = $"Your construct has a mounted dart launcher, embedded cannon, or similar armament. Your innovation gains a ranged unarmed attack that deals 1d4 bludgeoning or piercing damage (you choose when you pick this modification). The attack has the {ToMarkdownLink<Models.Entities.Trait>("propulsive", Traits.Instances.Propulsive.ID)} trait and a range increment of 30 feet." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("b1b43512-8856-43d9-9fb1-60ad44c073dc"),
                SourceId = Sources.Instances.GunsAndGears.ID,
                Page = -1
            };
        }
    }
}
