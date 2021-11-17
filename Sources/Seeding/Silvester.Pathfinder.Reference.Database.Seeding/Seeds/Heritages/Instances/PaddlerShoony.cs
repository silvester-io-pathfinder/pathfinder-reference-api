using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Builders;
using Silvester.Pathfinder.Reference.Database.Effects.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Heritages.Instances
{
    public class PaddlerShoony : Template
    {
        public static readonly Guid ID = Guid.Parse("d858afb5-27d8-46ed-bfcf-5a766bd03cb3");

        protected override Heritage GetHeritage()
        {
            return new Heritage 
            { 
                Id = ID, 
                RarityId = Rarities.Instances.Common.ID, 
                Name = "Paddler Shoony"
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse("ed856b62-78d5-47f9-9927-3e87dd865f25"), Type = TextBlockType.Text, Text = "You hail from shoonies who have lived long and successfully among the reeds and cattails of swamps and marshes, and have adapted to the challenges of living near waterlogged areas. You ignore difficult terrain and greater difficult terrain from bogs. When you roll a success to Swim, you get a critical success instead." };
        }

        protected override void GetEffects(BooleanEffectBuilder builder)
        {
            builder.Manual(Guid.Parse("0c752311-95de-4f5b-87a3-0a4a47a65078"), "You ignore difficult terrain and greater difficult terrain from bogs.");
            builder.ImproveSpecificSkillActionCheck(Guid.Parse("a6769975-ff28-4108-8aa0-02013a07d7b4"), SkillActions.Instances.Swim.ID, RollResult.Success, becomes: RollResult.CriticalSuccess);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("7c215fa6-98bf-4567-a122-1fb7c77ebe35"),
                SourceId = Sources.Instances.Pathfinder153.ID,
                Page = 71
            };
        }

        protected override IEnumerable<Guid> GetAncestries()
        {
            yield return Ancestries.Instances.Shoony.ID;
        }
    }
}
