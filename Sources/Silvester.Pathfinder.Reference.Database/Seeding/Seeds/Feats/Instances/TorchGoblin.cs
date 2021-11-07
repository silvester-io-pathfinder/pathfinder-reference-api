using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class TorchGoblin : Template
    {
        public static readonly Guid ID = Guid.Parse("92009372-82b7-41a5-8f30-b9aae91033db");

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
            yield return new TextBlock { Id = Guid.Parse("16a48270-627b-4efa-8405-5e8f1aad960c"), Type = TextBlockType.Text, Text = "You’ve spent enough time on fire that you know how to use it to your advantage. You can light yourself thoroughly on fire with a held torch, a bottle of alchemist’s fire, or a similar incendiary, dealing yourself 1d6 persistent fire damage. As long as you are suffering persistent fire damage, all your melee attacks against adjacent creatures deal an additional 1 fire damage per weapon damage die. Any creature that successfully (action: Grapples | Grapple), (action: Shoves | Shove), or (action: Trips | Trip) you takes 1d6 fire damage; if it uses a weapon for that action, the weapon takes the damage instead. You must still attempt the flat check to remove the persistent fire damage each round, as normal." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificHeritage(Guid.Parse("d6428c8f-af80-405b-a765-ee54c8778c2f"), Heritages.Instances.CharchideGoblin.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("4a75011b-4213-482d-b4a6-be59df445e17"),
                SourceId = Sources.Instances.LostOmensCharacterGuide.ID,
                Page = -1
            };
        }
    }
}
