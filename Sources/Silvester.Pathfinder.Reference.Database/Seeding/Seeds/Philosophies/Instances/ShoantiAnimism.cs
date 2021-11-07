using Silvester.Pathfinder.Reference.Database.Effects;
using Silvester.Pathfinder.Reference.Database.Effects.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Builders;
using Silvester.Pathfinder.Reference.Database.Utilities.Tables;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Philosophies.Instances
{
    public class ShoantiAnimism : Template
    {
        public static readonly Guid ID = Guid.Parse("");
        
        protected override Philosophy GetPhilosophy()
        {
            return new Philosophy
            {
                Id = ID, 
                Name = "Shoanti Animism",
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Text, Text = "Most Shoanti belong to one of seven quahs, or clans, each with specific lands, notable strengths, and unique spiritual perspectives. Traditionally, each Shoanti undergoes a rite of passage into adulthood, during which time their particular totem manifests, and a Shoanti’s first tattoo is an homage to that totem. The quahs and their most common totems are listed below:" };
            yield return new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Enumeration, Text = "Lyrune-Quah (Moon Clan) - Bat, cave bear, moon, mountain lion, owl, stars." };
            yield return new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Enumeration, Text = "Shadde-Quah (Axe Clan) - Cliffs, eagle, sea, shark, squid, water elemental." };
            yield return new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Enumeration, Text = "Shriikirri-Quah (Hawk Clan) - Cloud, falcon, hawk, hippogriff, horse, wind." };
            yield return new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Enumeration, Text = "Shundar-Quah (Spire Clan) - Avalanche, earth elemental, mountain spire or peak, roc, spirestalker." };
            yield return new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Enumeration, Text = "Sklar-Quah (Sun Clan) - Aurochs, cindersnake, emberstorm, fire elemental, flames, the sun." };
            yield return new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Enumeration, Text = "Skoan-Quah (Skull Clan) - Ancestors, earth elemental, giant scarab beetle, vulture, will-o’-wisp, wolf." };
            yield return new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Enumeration, Text = "Tamiir-Quah (Wind Clan) - Air elemental, cloud, griffon, roc, storm, wind." };
            yield return new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Text, Text = "According to their own tradition, Shoanti have lived in the northwestern lands of Avistan since long before colonizers fractured the Varisians’ homeland. Yet the Shoanti people still maintain their independence and traditional way of life in areas across Varisia, particularly on the Storval Plateau." };
            yield return new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Text, Text = "Shoanti animism is rooted in a deep connection to the land. Shoanti see the earth not merely as a metaphorical parent, but as a conscious entity whose constant support is necessary for the survival of all life upon it—animal and vegetable alike. Their traditions emphasize connection and the reciprocal way in which the land provides for those who take care of it. The life force of the land serves as the source of Shoanti power and insight, rather than the otherworldly spiritual essence of the Great Beyond common to clerics. This life force is the birth of instinct and faith, and thus it sends omens to indicate future events, warning those with the wisdom to read the signs. Thus most Shoanti hold a profound reverence for natural phenomena as a manifestation of the will of the earth." };
        }

        protected override IEnumerable<Guid> GetRequiredAlignments()
        {
            yield break;
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse(""),
                SourceId = Sources.Instances.LostOmensGodsAndMagic.ID,
                Page = 100
            };
        }
    }
}
