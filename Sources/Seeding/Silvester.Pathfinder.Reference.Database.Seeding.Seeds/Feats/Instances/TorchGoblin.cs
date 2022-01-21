using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class TorchGoblin : Template
    {
        public static readonly Guid ID = Guid.Parse("1d726e47-c2c8-4fa0-b85c-396f458f4cc5");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Torch Goblin",
                Level = 5,
                ActionTypeId = ActionTypes.Instances.OneAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("31741b11-a5d6-428e-b8db-6e87b336528d"), Type = TextBlockType.Text, Text = "You've spent enough time on fire that you know how to use it to your advantage. You can light yourself thoroughly on fire with a held torch, a bottle of alchemist's fire, or a similar incendiary, dealing yourself 1d6 persistent fire damage. As long as you are suffering persistent fire damage, all your melee attacks against adjacent creatures deal an additional 1 fire damage per weapon damage die. Any creature that successfully (action: Grapples | Grapple), (action: Shoves | Shove), or (action: Trips | Trip) you takes 1d6 fire damage; if it uses a weapon for that action, the weapon takes the damage instead. You must still attempt the flat check to remove the persistent fire damage each round, as normal." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificHeritage(Guid.Parse("2f8a0fa5-ccbe-43bf-a364-b3597ccd5e12"), Heritages.Instances.CharhideGoblin.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("1e553762-9229-4b75-9825-f13b1272285f"),
                SourceId = Sources.Instances.LostOmensCharacterGuide.ID,
                Page = -1
            };
        }
    }
}
