using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class ModificationDynamicWeighting : Template
    {
        public static readonly Guid ID = Guid.Parse("b3c356a8-4a8b-431c-9a26-963908a17d79");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Modification - Dynamic Weighting",
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
            yield return new TextBlock { Id = Guid.Parse("e86a4103-489e-404e-b7d5-8927d7852638"), Type = TextBlockType.Enumeration, Text = "*One-handed Melee Weapon Only; Can’t Have the (trait: Agile), (trait: Attached), or (trait: Free-hand) Trait**" };
            yield return new TextBlock { Id = Guid.Parse("1d8cab7f-b4ab-4430-a568-e8845b7c7c3d"), Type = TextBlockType.Text, Text = "Your weapon’s modified weight distribution can increase power in exchange for taking more hands to wield. Your innovation gains the (trait: two-hand) trait, with a damage die one size higher than the weapon’s normal weapon damage die size (for instance, a longsword would gain the (trait: two-hand d10) trait). Your innovation also gains the (trait: versatile B) trait." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("df8e96b7-cb2f-4d57-a8bb-86797c48d113"),
                SourceId = Sources.Instances.GunsAndGears.ID,
                Page = -1
            };
        }
    }
}
